namespace ApiMokymai.Services
{
    public interface IOperation
    {
        string GetOperationId();
    }
    public interface IMyOperationTransient : IOperation { }
    public interface IMyOperationScoped : IOperation { }
    public interface IMyOperationSingleton : IOperation { }
}