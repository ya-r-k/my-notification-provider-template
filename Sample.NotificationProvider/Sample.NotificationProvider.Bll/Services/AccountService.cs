using Sample.NotificationProvider.Common.EmailModels;

namespace Sample.NotificationProvider.Bll.Services;

public class AccountService : IAccountService
{
    public Task ActivateAccountAsync(AccountActivationEmailModel model)
    {
        throw new NotImplementedException();
    }

    public Task CloseAccountAsync(CloseAccountEmailModel model)
    {
        throw new NotImplementedException();
    }

    public Task LockoutAccountAsync(LockoutAccountEmailModel model)
    {
        throw new NotImplementedException();
    }

    public Task ResetPasswordAsync(PasswordResetEmailModel model)
    {
        throw new NotImplementedException();
    }

    public Task SendLoginAlert(LoginAlertEmailModel model)
    {
        throw new NotImplementedException();
    }
}
