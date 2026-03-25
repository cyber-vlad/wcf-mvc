namespace Platform.Client.WcfEndpoints
{
    public class Service1 : IService1
    {
        private readonly ServiceClient _serviceClient = new ServiceClient("NetTcpBinding_IService");

        public string Handle(string product)
        {
            return _serviceClient.RegisterTopic(product);
        }
    }
}
