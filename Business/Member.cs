using DataAccess;
using DataAccess.DTOs;
using System;
using System.Data;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Member
    {
        public enum ModeType
        {
            Add,
            Update
        }

        private MemberDTO _memberDto;
        private ModeType _currentMode;

        public ModeType CurrentMode
        {
            get => _currentMode;
            set => _currentMode = value;
        }
        public int MemberId
        {
            get => _memberDto.MemberId;
            set => _memberDto.MemberId = value;
        }

        public DateTime MemberJoinDate
        {
            get => _memberDto.MemberJoinDate;
            set => _memberDto.MemberJoinDate = value;
        }

        public int UserId
        {
            get => _memberDto.UserId;
            set => _memberDto.UserId = value;
        }

        public int MembershipTypeId
        {
            get => _memberDto.MembershipTypeId;
            set => _memberDto.MembershipTypeId = value;
        }

        public DateTime MembershipExpirationDate
        {
            get => _memberDto.MembershipExpirationDate;
            set => _memberDto.MembershipExpirationDate = value;
        }

        public User UserInfo { get; set; }

        public MembershipType MembershipTypeInfo { get; set; }


        public Member()
        {
            _memberDto = new MemberDTO();
            _currentMode = ModeType.Add;
        }

        private Member(MemberDTO memberDto)
        {
            _memberDto = memberDto;
            UserInfo = User.FindUserById(memberDto.UserId);
            MembershipTypeInfo = MembershipType.FindById(memberDto.MembershipTypeId);
            _currentMode = ModeType.Update;
        }

        public static Member FindByUserId(int userId)
        {
            MemberDTO memberDto = MemberData.GetMemberByUserId(userId);
            return memberDto == null ? null : new Member(memberDto);
        }

        public static Member FindByMemberId(int memberId)
        {
            MemberDTO memberDto = MemberData.GetMemberById(memberId);
            return memberDto == null ? null : new Member(memberDto);
        }

        private bool Add()
        {
            MemberId = MemberData.CreateMember(_memberDto);
            return MemberId != -1;
        }

        private bool Update()
        {
            return MemberData.UpdateMember(_memberDto);
        }

        public bool Save()
        {
            if (_currentMode == ModeType.Add)
            {
                if (Add())
                {
                    _currentMode = ModeType.Update;
                    return true;
                }

                return false;
            }

            return Update();
        }

        public static bool Delete(int memberId)
        {
            return MemberData.DeleteMember(memberId);
        }

        public static async Task<DataTable> GetAllAsync(User currentUser)
        {
            if (currentUser.HasPermission(User.Permissions.All))
                return await MemberData.GetAllMembersAsync();

            if (currentUser.HasPermission(User.Permissions.ManageMembers))
                return await MemberData.GetAllMembersByUserIdAsync(currentUser.UserId);

            return null;
        }

        public bool IsMembershipExpired()
        {
            return MemberData.IsMembershipExpired(MemberId);
        }

        public bool IsAtBorrowLimit()
        {
            return MemberData.HasReachedBorrowLimit(MemberId);
        }

        public bool HasGeneralFees()
        {
            return MemberData.HasGeneralFees(MemberId);
        }

        public static int GetMemberIDByUserID(int userId)
        {
            return MemberData.GetMemberIDByUserID(userId);
        }

        public bool HasBorrowHistory()
        {
            return MemberData.HasBorrowHistory(MemberId);
        }

        public static Member FindMemberByPaymentID(int paymentId)
        {
            MemberDTO memberDto = MemberData.FindMemberByPaymentID(paymentId);
            return memberDto == null ? null : new Member(memberDto);
        }

    }
}