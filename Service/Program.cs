using Microsoft.Extensions.Hosting;
using Service.Startup;

namespace Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GenericHostBuilder.Build(args).Run();
        }
    }
}