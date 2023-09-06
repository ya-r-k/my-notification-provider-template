using Microsoft.Extensions.DependencyInjection;

namespace Sample.NotificationProvider.IntegrationTests;

internal abstract class IntegrationTestBase : IDisposable
{
    protected readonly CustomWebApplicationFactory factory;
    protected readonly HttpClient httpClient;

    protected IntegrationTestBase()
    {
        factory = new CustomWebApplicationFactory();
        httpClient = factory.CreateClient();
        httpClient.BaseAddress = new Uri("http://localhost");

        var serviceProvider = factory.Services;
    }

    public void Dispose()
    {
        httpClient?.Dispose();
        factory.Server?.Dispose();
    }
}
