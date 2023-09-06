using Sample.NotificationProvider.Common.EmailModels.Interfaces;

namespace Sample.NotificationProvider.MailAccess.Infrastructure;

public class EmailSenderModel<T>
{
    public string AuthorName { get; set; }

    public string AuthorEmail { get; set; }

    public string Subject { get; set; }

    public string Template { get; set; }

    public T Data { get; set; }
}
