using System.ServiceModel;

namespace Platform.Service
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string GetData(int value);
    }
}
