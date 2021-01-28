using MEFCalculator.Demo.Base.Data;
using MEFCalculator.Demo.Base.Interface;

namespace MEFCalculator.Demo.Operations
{
    public class Operation : IOperation
    {
        public virtual OperationResult Run(decimal digit)
        {
            return new OperationResult("Unvalid operator!");
        }

        public virtual OperationResult Run(decimal leftDigit, decimal rightDigit)
        {
            return new OperationResult("Unvalid operator!");
        }
    }
}