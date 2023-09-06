using Sample.NotificationProvider.Common.EmailModels.Interfaces;

namespace Sample.NotificationProvider.MailAccess.Renderers;

public interface IHtmlRenderer
{
    Task<string> RenderAsync<T>(string template, T data);
}
