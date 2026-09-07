using DataAccess;
using DataAccess.DTOs;
using System;
using System.Data;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class FinePayment
    {
        public enum ModeType
        {
            Add = 1,
            Update = 2
        }

        private FinePaymentDTO _paymentDto;
        private ModeType _currentMode;

        public int PaymentId
        {
            get => _paymentDto.PaymentId;
            set => _paymentDto.PaymentId = value;
        }

        public int FineId
        {
            get => _paymentDto.FineId;
            set => _paymentDto.FineId = value;
        }

        public decimal AmountPaid
        {
            get => _paymentDto.AmountPaid;
            set => _paymentDto.AmountPaid = value;
        }

        public DateTime PaymentDate
        {
            get => _paymentDto.PaymentDate;
            set => _paymentDto.PaymentDate = value;
        }

        public string PaymentMethod
        {
            get => _paymentDto.PaymentMethod;
            set => _paymentDto.PaymentMethod = value;
        }

        public Fine FineInfo { get; set; }

        public FinePayment()
        {
            _paymentDto = new FinePaymentDTO();
            _currentMode = ModeType.Add;
        }

        private FinePayment(FinePaymentDTO paymentDto)
        {
            _paymentDto = paymentDto;
            FineInfo = Fine.FindByFineId(paymentDto.FineId);
            _currentMode = ModeType.Update;
        }

        public static FinePayment FindByBorrowId(int borrowId)
        {
            FinePaymentDTO paymentDto = FinePaymentsData.GetPaymentByBorrowId(borrowId);
            return paymentDto == null ? null : new FinePayment(paymentDto);
        }

        public static FinePayment FindByPaymentId(int paymentId)
        {
            FinePaymentDTO paymentDto = FinePaymentsData.GetPaymentById(paymentId);
            return paymentDto == null ? null : new FinePayment(paymentDto);
        }

        public static decimal GetTotalAmountPaid(int fineId)
        {
            return FinePaymentsData.GetTotalAmountPaidByFineId(fineId);
        }

        private bool Add()
        {
            PaymentId = FinePaymentsData.CreateFinePayment(_paymentDto, FineInfo.RenewId);
            return PaymentId > 0;
        }

        private bool Update()
        {
            return FinePaymentsData.UpdateFinePayment(_paymentDto);
        }

        public static async Task<DataTable> GetAllAsync(User currentUser, int memberId)
        {
            if (currentUser.HasPermission(User.Permissions.All))
                return await FinePaymentsData.GetAllFinePaymentsAsync();

            if (currentUser.HasPermission(User.Permissions.ManageFinePayments))
                return await FinePaymentsData.GetAllFinePaymentsByMemberIdAsync(memberId);

            return null;
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
    }
}