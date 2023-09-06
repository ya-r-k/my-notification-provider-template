using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.NotificationProvider.IntegrationTests;

internal class CustomWebApplicationFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureAppConfiguration(builder =>
        {
            builder.AddInMemoryCollection(new Dictionary<string, string>
            {
            });
        });

        builder.ConfigureServices(services =>
        {
            AddDataAccessors(services);
        });

        builder.UseEnvironment("Testing");
    }

    private static void AddDataAccessors(IServiceCollection services)
    {
    }
}
