using MEFCalculator.Demo.Base.Enum;

namespace MEFCalculator.Demo.Base.Interface
{
    public interface IOperationMetadata
    {
        string Description { get; }
        string Command { get; }
        OperationType OperationType { get; }
    }
}
