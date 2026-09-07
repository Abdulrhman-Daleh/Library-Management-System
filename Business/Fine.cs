using DataAccess;
using DataAccess.DTOs;
using System;
using System.Data;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Fine
    {
        public enum ModeType
        {
            Add = 1,
            Update = 2
        }

        public enum StatusType
        {
            Completed = 1,
            Pending = 2
        }

        public enum ProcessMode
        {
            BorrowFine = 1,
            MembershipRenewal = 2
        }

        private FineDTO _fineDto;
        private ModeType _currentMode;

        public string GetStatusText()
        {
            switch(FineStatus)
            {
                case StatusType.Completed:
                    return "Completed";

                case StatusType.Pending:
                    return "Pending";

                default:
                    return "Pending";
            }
        }

        public int FineId
        {
            get => _fineDto.FineId;
            set => _fineDto.FineId = value;
        }

        public int? BorrowId
        {
            get => _fineDto.BorrowId;
            set => _fineDto.BorrowId = value;
        }

        public StatusType FineStatus
        {
            get => (StatusType)_fineDto.FineStatusId;
            set => _fineDto.FineStatusId = (int)value;
        }

        public decimal FineAmount
        {
            get => _fineDto.FineAmount;
            set => _fineDto.FineAmount = value;
        }

        public string Reason
        {
            get => _fineDto.Reason;
            set => _fineDto.Reason = value;
        }

        public DateTime? CreatedDate
        {
            get => _fineDto.CreatedDate;
            set => _fineDto.CreatedDate = value;
        }

        public DateTime? ClosedDate
        {
            get => _fineDto.ClosedDate;
            set => _fineDto.ClosedDate = value;
        }

        public int? RenewId
        {
            get => _fineDto.RenewId;
            set => _fineDto.RenewId = value;
        }

        public BorrowTransaction BorrowTransaction { get; set; }
        public MembershipRenew MembershipRenewDetails { get; set; }

        public Fine()
        {
            _fineDto = new FineDTO();
            _currentMode = ModeType.Add;
            FineStatus = StatusType.Pending;
        }

        private Fine(FineDTO fineDto)
        {
            _fineDto = fineDto;
            BorrowTransaction = BorrowTransaction.FindByBorrowId(fineDto.BorrowId);
            MembershipRenewDetails = MembershipRenew.FindByRenewId(fineDto.RenewId);
            _currentMode = ModeType.Update;
        }

        public string GetReasonText()
        {
            return string.IsNullOrEmpty(Reason) ? "Reason Not Provided" : Reason;
        }

        public static Fine FindByBorrowId(int borrowId)
        {
            FineDTO fineDto = FinesData.GetFineByBorrowId(borrowId);
            return fineDto == null ? null : new Fine(fineDto);
        }

        public static Fine FindByFineId(int fineId)
        {
            FineDTO fineDto = FinesData.GetFineById(fineId);
            return fineDto == null ? null : new Fine(fineDto);
        }

        private bool Add()
        {
            FineId = FinesData.CreateFine(_fineDto);
            return FineId > 0;
        }

        private bool Update()
        {
            return FinesData.UpdateFine(_fineDto);
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

        public static async Task<DataTable> GetAllAsync(User currentUser, int memberId)
        {
            if (currentUser.HasPermission(User.Permissions.All))
                return await FinesData.GetAllFinesAsync();

            if (currentUser.HasPermission(User.Permissions.None))
                return null;

            return await FinesData.GetAllFinesByMemberIdAsync(memberId);
        }

        public static bool HasReturnFees(int borrowId)
        {
            return FinesData.HasReturnFees(borrowId);
        }

        public decimal GetRemainingFines()
        {
            return FineAmount - FinePayment.GetTotalAmountPaid(FineId);
        }

        public static bool HasMembershipRenewalFees(int renewId)
        {
            return FinesData.HasMembershipRenewalFees(renewId);
        }

        public ProcessMode GetFineType()
        {
            return BorrowId == null ? ProcessMode.MembershipRenewal : ProcessMode.BorrowFine;
        }

        public static decimal GetAllUnpaidFinesAmount(int memberId)
        {
            return FinesData.GetAllUnpaidFinesAmount(memberId);
        }

    }
}