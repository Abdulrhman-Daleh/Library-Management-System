using Data_Access.DTOs;
using DataAccess;
using DataAccess.DTOs;

namespace BusinessLogic
{
    public class BookConditions
    {
        public enum Mode
        {
            Add = 1,
            Update = 2
        }

        public enum ConditionType
        {
            AsNew = 1,
            Fine = 2,
            NearFine = 3,
            VeryGood = 4,
            Good = 5,
            Fair = 6,
            Poor = 7
        }

        private Mode _currentMode;
        private decimal _conditionFees;
        private ConditionType _bookConditionType;
        private string _conditionTitle;

        public Mode CurrentMode => _currentMode;
        public decimal ConditionFees => _conditionFees;
        public ConditionType BookConditionType => _bookConditionType;
        public string ConditionTitle => _conditionTitle;

        public BookConditions()
        {
            _currentMode = Mode.Add;
        }

        private BookConditions(BookConditionDTO conditionDto)
        {
            _currentMode = Mode.Update;
            _conditionFees = conditionDto.ConditionFees;
            _bookConditionType = (ConditionType)conditionDto.ConditionId;
            _conditionTitle = conditionDto.ConditionTitle;
        }

        public static BookConditions FindBookCondition(int conditionId)
        {
            BookConditionDTO conditionDto = BookConditionData.GetBookConditionById(conditionId);
            return conditionDto == null ? null : new BookConditions(conditionDto);
        }

        public static int GetConditionIdByName(string conditionName)
        {
            return BookConditionData.GetConditionIdByName(conditionName);
        }
    }
}