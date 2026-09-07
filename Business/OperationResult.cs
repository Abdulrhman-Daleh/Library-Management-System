namespace BusinessLogic
{
    public class OperationResult
    {
        public string Message { get; set; }
        public bool Success { get; set; }

        public OperationResult(string message, bool success)
        {
            Message = message;
            Success = success;
        }

        public static OperationResult Create(string message, bool success)
        {
            return new OperationResult(message, success);
        }
    }
}