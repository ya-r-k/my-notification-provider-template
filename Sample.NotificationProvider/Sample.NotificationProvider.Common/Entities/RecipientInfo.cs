using System.ComponentModel.DataAnnotations;

namespace Sample.NotificationProvider.Common.Entities;

/// <summary>
/// Represents a recipient information of a notification.
/// </summary>
public class RecipientInfo
{
    /// <summary>
    /// Gets or sets the family name or surname of the recipient.
    /// </summary>
    [Required]
    public string FamilyName { get; set; }

    /// <summary>
    /// Gets or sets the given name or first name of the recipient.
    /// </summary>
    [Required]
    public string GivenName { get; set; }

    /// <summary>
    /// Gets or sets the email address of the recipient.
    /// </summary>
    [Required]
    [EmailAddress]
    public string EmailAddress { get; set; }
}
