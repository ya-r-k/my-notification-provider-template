using Sample.NotificationProvider.Common.EmailModels.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Sample.NotificationProvider.Common.EmailModels;

/// <summary>
/// Represents the model for the account activation email.
/// </summary>
public class AccountActivationEmailModel : BaseEmailModel
{
    /// <summary>
    /// Gets or sets the unique URL that the user can click on to activate their account.
    /// </summary>
    [Required]
    public string ActivationLink { get; set; }

    /// <summary>
    /// Gets or sets the clear instructions on how to activate the account.
    /// </summary>
    public string Instructions { get; set; }

    /// <summary>
    /// Gets or sets any extra relevant information or resources that may be helpful during the account activation process.
    /// </summary>
    public string AdditionalInformation { get; set; }

    /// <summary>
    /// Gets or sets the contact details of the support team or a designated contact person for any activation-related questions or issues.
    /// </summary>
    public string ContactInformation { get; set; }

    /// <summary>
    /// Gets or sets the exact date and time when the account activation will expire.
    /// </summary>
    [Required]
    public DateTime ExpirationDate { get; set; }
}
