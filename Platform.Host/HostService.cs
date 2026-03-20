using Platform.Service;
using System;
using System.ServiceModel;
using Topshelf;

namespace Platform.Host
{
    public class HostService
    {
        private ServiceHost _serviceHost = null;

        public void Start()
        {
            if (_serviceHost != null)
            {
                _serviceHost.Close();
            }

            try
            {
                _serviceHost = new ServiceHost(typeof(TopicService));
                _serviceHost.Open();
                Console.WriteLine("WCF Service started.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                throw;
            }
        }

        public void Stop()
        {
            if (_serviceHost != null)
            {
                _serviceHost.Close();
                _serviceHost = null;
                Console.WriteLine("WCF Service stopped.");
            }
        }
    }
}
