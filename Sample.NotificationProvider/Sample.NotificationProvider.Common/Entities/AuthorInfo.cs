using System.ComponentModel.DataAnnotations;

namespace Sample.NotificationProvider.Common.Entities;

public class AuthorInfo
{
    [Required]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string EmailAddress { get; set; }
}
