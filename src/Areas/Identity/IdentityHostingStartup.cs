using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(CoreNg.Areas.Identity.IdentityHostingStartup))]
namespace CoreNg.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}