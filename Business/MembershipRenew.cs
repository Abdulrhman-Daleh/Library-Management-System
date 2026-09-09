using DataAccess;
using DataAccess.DTOs;
using System;
using System.Data;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MembershipRenew
    {
        public enum ModeType
        {
            Add,
            Update
        }

        private MembershipRenewDTO _renewDto;
        private ModeType _currentMode;

        public int RenewId
        {
            get => _renewDto.RenewId;
            set => _renewDto.RenewId = value;
        }

        public int MemberId
        {
            get => _renewDto.MemberId;
            set => _renewDto.MemberId = value;
        }

        public int MembershipTypeId
        {
            get => _renewDto.MembershipTypeId;
            set => _renewDto.MembershipTypeId = value;
        }

        public DateTime RenewDate
        {
            get => _renewDto.RenewDate;
            set => _renewDto.RenewDate = value;
        }

        public decimal RenewFees
        {
            get => _renewDto.RenewFees;
            set => _renewDto.RenewFees = value;
        }

        public bool IsPaid
        {
            get => _renewDto.IsPaid;
            set => _renewDto.IsPaid = value;
        }

        public Member MemberInfo { get; set; }

        public MembershipRenew()
        {
            _renewDto = new MembershipRenewDTO();
            _currentMode = ModeType.Add;
        }

        private MembershipRenew(MembershipRenewDTO renewDto)
        {
            _renewDto = renewDto;
            MemberInfo = Member.FindByMemberId(renewDto.MemberId);
            _currentMode = ModeType.Update;
        }

        public static async Task<DataTable> GetAllAsync(User currentUser, int memberId)
        {
            if (currentUser.HasPermission(User.Permissions.All))
                return await MembershipRenewData.GetAllRenewalsAsync();

            if (currentUser.HasPermission(User.Permissions.ManageMembershipRenews))
                return await MembershipRenewData.GetAllRenewalsByMemberIdAsync(memberId);

            return null;
        }

        public static MembershipRenew FindByRenewId(int? renewId)
        {
            MembershipRenewDTO renewDto = MembershipRenewData.FindByRenewId(renewId);
            return renewDto == null ? null : new MembershipRenew(renewDto);
        }

        public static MembershipRenew FindByMemberId(int memberId)
        {
            MembershipRenewDTO renewDto = MembershipRenewData.FindByMemberId(memberId);
            return renewDto == null ? null : new MembershipRenew(renewDto);
        }

        public static async Task<DataTable> GetRenewalsByMemberId(int memberId)
        {
            return await MembershipRenewData.GetRenewalsByMemberId(memberId);
        }

        private bool Add()
        {
            RenewId = MembershipRenewData.Add(_renewDto);
            return RenewId != -1;
        }

        private bool Update()
        {
            return MembershipRenewData.Update(_renewDto);
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

        public static bool Delete(int renewId)
        {
            return MembershipRenewData.Delete(renewId);
        }

        public static int GetMemberIdByRenewId(int? renewId)
        {
            return MembershipRenewData.GetMemberIdByFineId(renewId);
        }
    }
}