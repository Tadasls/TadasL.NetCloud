using ApiMokymai.Interfaces;

namespace ApiMokymai.Controllers.P001
{
    public class GuidService : IMyOperationTransient, IMyOperationScoped, IMyOperationSingleton
    {
        private readonly string _operationId;

        public GuidService()
        {
            _operationId = Guid.NewGuid().ToString();
        }

        public string GetOperationId()
        {
            return _operationId;
        }

    }
}