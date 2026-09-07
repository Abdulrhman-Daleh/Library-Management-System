using DataAccess;
using DataAccess.DTOs;
using System;
using System.Data;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Policy
    {
        public enum ModeType
        {
            Add = 1,
            Update = 2
        }

        private PolicyDTO _policyDto;
        private ModeType _currentMode;

        public ModeType CurrentMode
        {
            get => _currentMode;
            set => _currentMode = value;
        }
        public int PolicyId
        {
            get => _policyDto.PolicyId;
            set => _policyDto.PolicyId = value;
        }

        public decimal FeesPerLateDay
        {
            get => _policyDto.FeesPerLateDay;
            set => _policyDto.FeesPerLateDay = value;
        }

        public int GracePeriodDays
        {
            get => _policyDto.GracePeriodDays;
            set => _policyDto.GracePeriodDays = value;
        }

        public decimal LostBookFeeMultiplier
        {
            get => _policyDto.LostBookFeeMultiplier;
            set => _policyDto.LostBookFeeMultiplier = value;
        }

        public DateTime EffectiveFrom
        {
            get => _policyDto.EffectiveFrom;
            set => _policyDto.EffectiveFrom = value;
        }

        public DateTime EffectiveTo
        {
            get => _policyDto.EffectiveTo;
            set => _policyDto.EffectiveTo = value;
        }

        public Policy()
        {
            _policyDto = new PolicyDTO();
            _currentMode = ModeType.Add;
        }

        private Policy(PolicyDTO policyDto)
        {
            _policyDto = policyDto;
            _currentMode = ModeType.Update;
        }

        public static Policy GetCurrentActivePolicy()
        {
            PolicyDTO policyDto = PolicyData.GetCurrentActivePolicy();
            return policyDto == null ? null : new Policy(policyDto);
        }

        public static Policy GetPolicyById(int policyId)
        {
            PolicyDTO policyDto = PolicyData.GetPolicyById(policyId);
            return policyDto == null ? null : new Policy(policyDto);
        }

        private bool Add()
        {
            int policyId = PolicyData.AddPolicy(_policyDto);
            if (policyId <= 0)
                return false;

            PolicyId = policyId;
            return true;
        }

        private bool Update()
        {
            return PolicyData.UpdatePolicy(_policyDto);
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

        public bool IsActive()
        {
            return EffectiveTo > DateTime.Now;
        }

        public static async Task<DataTable> GetAllAsync()
        {
            return await PolicyData.GetAllPoliciesAsync();
        }

        public static bool DeletePolicy(int policyId)
        {
            return PolicyData.DeletePolicy(policyId);
        }
    }
}