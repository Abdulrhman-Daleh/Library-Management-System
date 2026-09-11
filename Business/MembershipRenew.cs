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
            View
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

        private MembershipRenew(MembershipRenewDTO renewDto)
        {
            _renewDto = renewDto;
            MemberInfo = Member.FindByMemberId(renewDto.MemberId);
            _currentMode = ModeType.View;
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

    }
}