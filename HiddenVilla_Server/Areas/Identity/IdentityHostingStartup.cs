using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(HiddenVilla_Server.Areas.Identity.IdentityHostingStartup))]
namespace HiddenVilla_Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => { });
        }
    }
}