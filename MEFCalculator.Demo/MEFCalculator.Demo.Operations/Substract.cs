using MEFCalculator.Demo.Base.Data;
using MEFCalculator.Demo.Base.Enum;
using MEFCalculator.Demo.Base.Interface;
using System.ComponentModel.Composition;

namespace MEFCalculator.Demo.Operations
{
    [Export(typeof(IOperation))]
    [ExportMetadata("Description", "Substract")]
    [ExportMetadata("Command", "-")]
    [ExportMetadata("OperationType", OperationType.Binary)]
    public class Substract : Operation
    {
        public override OperationResult Run(decimal leftDigit, decimal rightDigit)
        {
            return new OperationResult(leftDigit - rightDigit);
        }

        public override OperationResult Run(decimal digit)
        {
            return new OperationResult(digit * -1);
        }
    }
}
