namespace Sample.NotificationProvider.Common.Settings;

/// <summary>
/// Represents the SMTP settings for configuring the MailKit SmtpClient.
/// </summary>
public class SmtpSettings
{
    /// <summary>
    /// Gets or sets the SMTP server address.
    /// </summary>
    public string SmtpServer { get; set; }

    /// <summary>
    /// Gets or sets the SMTP server port number.
    /// </summary>
    public int SmtpPort { get; set; }

    /// <summary>
    /// Gets or sets the username for SMTP authentication.
    /// </summary>
    public string SmtpUsername { get; set; }

    /// <summary>
    /// Gets or sets the password for SMTP authentication.
    /// </summary>
    public string SmtpPassword { get; set; }
}
