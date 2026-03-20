using Topshelf;

namespace Platform.Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(hostConfig =>
            {
                hostConfig.Service<HostService>(serviceConfig =>
                {
                    serviceConfig.ConstructUsing(name => new HostService());
                    serviceConfig.WhenStarted(s => s.Start());
                    serviceConfig.WhenStopped(s => s.Stop());
                });

                hostConfig.RunAsLocalSystem();
                hostConfig.SetServiceName("Topshelf Host Service");
                //hostConfig.SetDisplayName("My WCF Service Hosted by Topshelf");
                //hostConfig.SetDescription("A WCF service hosted within a Windows Service using Topshelf.");
                hostConfig.StartAutomatically();
            });
        }
    }
}
