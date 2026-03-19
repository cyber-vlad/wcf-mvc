using System.ServiceProcess;

namespace Platform.Host
{
    internal static class Program
    {
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new HostService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
