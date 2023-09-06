using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using Sample.NotificationProvider.Common.EmailModels.Interfaces;
using Sample.NotificationProvider.Common.Settings;
using Sample.NotificationProvider.MailAccess.Infrastructure;
using Sample.NotificationProvider.MailAccess.Renderers;

namespace Sample.NotificationProvider.MailAccess.Senders;

public class EmailSender
{
    private readonly SmtpSettings options;

    private readonly IHtmlRenderer htmlRenderer;

    public EmailSender(IOptions<SmtpSettings> options, IHtmlRenderer htmlRenderer)
    {
        this.options = options.Value;
        this.htmlRenderer = htmlRenderer;
    }

    public async Task SendEmailAsync<T>(EmailSenderModel<T> model) where T : BaseEmailModel
    {
        using var client = new SmtpClient();
        client.Connect(options.SmtpServer, options.SmtpPort, false);
        client.Authenticate(options.SmtpUsername, options.SmtpPassword);

        var bodyBuilder = new BodyBuilder
        {
            HtmlBody = await htmlRenderer.RenderAsync(model.Template, model.Data)
        };

        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(model.AuthorName, model.AuthorEmail));
        message.To.Add(new MailboxAddress($"{model.Data.Recipient.GivenName} {model.Data.Recipient.FamilyName}", model.Data.Recipient.EmailAddress));
        message.Subject = model.Subject;
        message.Body = bodyBuilder.ToMessageBody();

        var response = await client.SendAsync(message);

        client.Disconnect(true);
    }
}
