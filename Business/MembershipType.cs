using DataAccess;
using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MembershipType
    {
        public enum ModeType
        {
            Add = 1,
            Update = 2
        }

        private MembershipTypeDTO _membershipTypeDto;
        private ModeType _currentMode;

        public ModeType CurrentMode
        {
            get => _currentMode;
            set => _currentMode = value;
        }

        public int MembershipTypeId
        {
            get => _membershipTypeDto.MembershipTypeId;
            set => _membershipTypeDto.MembershipTypeId = value;
        }

        public string MembershipTypeName
        {
            get => _membershipTypeDto.MembershipTypeName;
            set => _membershipTypeDto.MembershipTypeName = value;
        }

        public float MembershipFees
        {
            get => _membershipTypeDto.MembershipFees;
            set => _membershipTypeDto.MembershipFees = value;
        }

        public int MembershipBorrowLimit
        {
            get => _membershipTypeDto.MembershipBorrowLimit;
            set => _membershipTypeDto.MembershipBorrowLimit = value;
        }

        public MembershipType()
        {
            _membershipTypeDto = new MembershipTypeDTO();
            _currentMode = ModeType.Add;
        }

        private MembershipType(MembershipTypeDTO membershipTypeDto)
        {
            _membershipTypeDto = membershipTypeDto;
            _currentMode = ModeType.Update;
        }

        public static MembershipType FindById(int membershipTypeId)
        {
            MembershipTypeDTO membershipTypeDto = MembershipTypeData.GetMembershipTypeById(membershipTypeId);
            return membershipTypeDto == null ? null : new MembershipType(membershipTypeDto);
        }

        public static MembershipType FindByName(string membershipTypeName)
        {
            MembershipTypeDTO membershipTypeDto = MembershipTypeData.GetMembershipTypeByName(membershipTypeName);
            return membershipTypeDto == null ? null : new MembershipType(membershipTypeDto);
        }

        private bool Add()
        {
            MembershipTypeId = MembershipTypeData.CreateMembershipType(_membershipTypeDto);
            return MembershipTypeId > 0;
        }

        private bool Update()
        {
            return MembershipTypeData.UpdateMembershipType(_membershipTypeDto);
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

        public static async Task<DataTable> GetAllAsync()
        {
            return await MembershipTypeData.GetAllMembershipTypesAsync();
        }

        public static List<string> GetMembershipTypeNames()
        {
            return MembershipTypeData.GetAllMembershipTypeNames();
        }

        public static bool DeleteMembershipType(int membershipTypeId)
        {
            return MembershipTypeData.DeleteMembershipType(membershipTypeId);
        }

        public int GetAllMembersCountInType()
        {
            return MembershipTypeData.GetAllMembersCountInType(MembershipTypeId);
        }

        public int GetAllBorrowedCountInType()
        {
            return MembershipTypeData.GetAllBorrowedCountInType(MembershipTypeId);
        }

        public decimal GetFinesAmountInType()
        {
            return MembershipTypeData.GetFinesAmountInType(MembershipTypeId);
        }
    }
}