using System.ServiceModel;

namespace Platform.Client.WcfEndpoints
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string Handle(string product);
    }
}
