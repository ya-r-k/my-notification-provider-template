using Sample.NotificationProvider.Common.EmailModels.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Sample.NotificationProvider.Common.EmailModels;

public class PasswordResetEmailModel : BaseEmailModel
{
    /// <summary>
    /// Gets or sets the unique URL that the user can click on to reset password in their account.
    /// </summary>
    [Required]
    public string ResetLink { get; set; }

    /// <summary>
    /// Gets or sets the contact details of the support team or a designated contact person for any password reset related questions or issues.
    /// </summary>
    public string ContactInformation { get; set; }

    /// <summary>
    /// Gets or sets the exact date and time when the password reset will expire.
    /// </summary>
    [Required]
    public DateTime ExpirationDate { get; set; }
}
