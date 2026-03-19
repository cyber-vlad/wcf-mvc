using System;
using System.ServiceProcess;
using Platform.Service;
using System.ServiceModel;
namespace Platform.Host
{
    public partial class HostService : ServiceBase
    {
        public HostService()
        {
            InitializeComponent();
        }

        ServiceHost host = null;

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(TopicService), new Uri("net.tcp://localhost:7001/service"));
            host.Open();
        }

        protected override void OnStop()
        {
            if(host != null)
            {
                host.Close();
            }

            host = null;
        }
    }
}
