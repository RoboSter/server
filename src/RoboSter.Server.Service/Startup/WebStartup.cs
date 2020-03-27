using JetBrains.Annotations;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using RoboSter.Server.Service.WebService;

namespace RoboSter.Server.Service.Startup
{
    public class WebStartup
    {
        [UsedImplicitly]
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient()
                .AddHttpClient<IWebApiClient, WebApiClient>(nameof(WebApiClient));

            services.AddMvc()
                .AddControllersAsServices()
                .AddNewtonsoftJson();
        }

        [UsedImplicitly]
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}