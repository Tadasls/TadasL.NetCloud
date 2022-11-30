using ApiMokymai.Interfaces;
using ApiMokymai.Interfaces.Kiti;

namespace ApiMokymai.Services.KitiServisai
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