using Microsoft.Extensions.Hosting;
using RoboSter.Server.Service.Startup;

namespace RoboSter.Server.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GenericHostBuilder.Build(args).Run();
        }
    }
}