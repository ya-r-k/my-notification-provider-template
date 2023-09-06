using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Sample.NotificationProvider.Bll.Services;
using Sample.NotificationProvider.Common.Settings;
using Sample.NotificationProvider.MailAccess.Infrastructure;
using Sample.NotificationProvider.MailAccess.Renderers;
using Sample.NotificationProvider.MailAccess.Senders;

namespace Sample.NotificationProvider.Di;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
    {
        services.AddTransient<IFileProvider, SystemFileProvider>();

        services.AddTransient<IHtmlRenderer, HtmlRenderer>();

        services.AddTransient<IAccountSender, AccountSender>();
        services.AddTransient<EmailSender>();

        services.AddTransient<IAccountService, AccountService>();

        services.Configure<SmtpSettings>(configuration.GetSection(nameof(SmtpSettings)));

        services.AddSingleton(Options.Create(new FileStorageSettings
        {
            FileStoragePath = environment.WebRootPath
        }));

        return services;
    }
}
