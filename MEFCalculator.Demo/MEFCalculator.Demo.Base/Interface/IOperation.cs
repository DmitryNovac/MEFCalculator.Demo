using MEFCalculator.Demo.Base.Data;

namespace MEFCalculator.Demo.Base.Interface
{
    public interface IOperation
    {
        OperationResult Run(decimal digit);
        OperationResult Run(decimal leftDigit, decimal rightDigit);
    }
}
