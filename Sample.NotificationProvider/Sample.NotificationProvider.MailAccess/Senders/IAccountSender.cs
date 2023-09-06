using Sample.NotificationProvider.Common.EmailModels;

namespace Sample.NotificationProvider.MailAccess.Senders;

public interface IAccountSender
{
    Task ActivateAccountAsync(AccountActivationEmailModel model);

    Task CloseAccountAsync(CloseAccountEmailModel model);

    Task LockoutAccountAsync(LockoutAccountEmailModel model);

    Task ResetPasswordAsync(PasswordResetEmailModel model);

    Task SendLoginAlert(LoginAlertEmailModel model);
}
