namespace MEFCalculator.Demo.Base.Data
{
    public class OperationResult
    {
        public OperationResult(string message)
        {
            ErrorMessage = message;
        }

        public OperationResult(decimal result)
        {
            Result = result;
        }

        public string ErrorMessage { get; set; }
        public decimal? Result { get; set; }
    }
}
