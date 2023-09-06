using Sample.NotificationProvider.Common.Entities;
using System.ComponentModel.DataAnnotations;

namespace Sample.NotificationProvider.Common.EmailModels.Interfaces;

public class BaseMulticastEmailModel
{
    /// <summary>
    /// Gets or sets the recipients list of the email.
    /// </summary>
    [Required]
    [MinLength(1)]
    public IEnumerable<RecipientInfo> Recipients { get; set; }
}
