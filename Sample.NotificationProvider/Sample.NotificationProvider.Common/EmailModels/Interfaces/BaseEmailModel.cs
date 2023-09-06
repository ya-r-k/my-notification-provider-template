using Sample.NotificationProvider.Common.Entities;
using System.ComponentModel.DataAnnotations;

namespace Sample.NotificationProvider.Common.EmailModels.Interfaces;

public abstract class BaseEmailModel
{
    /// <summary>
    /// Gets or sets the recipient of the email.
    /// </summary>
    [Required]
    public RecipientInfo Recipient { get; set; }
}
