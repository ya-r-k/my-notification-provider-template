using Microsoft.AspNetCore.Mvc;
using Sample.NotificationProvider.Bll.Services;
using Sample.NotificationProvider.Common.EmailModels;

namespace Sample.NotificationProvider.API.Controllers;

/// <summary>
/// Provides API endpoints for sending account related emails.
/// </summary>
[ApiController]
[Route("api/account")]
public class AccountController : ControllerBase
{
    private readonly IAccountService accountService;

    /// <summary>
    /// Initializes a new instance of the <see cref="AccountController"/> class.
    /// </summary>
    /// <param name="accountService">The account service.</param>
    public AccountController(IAccountService accountService)
    {
        this.accountService = accountService;
    }

    [HttpPost]
    [Route("activate")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> ActivateAccount(AccountActivationEmailModel model)
    {
        // TODO: Implement account activation logic
        await accountService.ActivateAccountAsync(model);

        return NoContent();
    }

    [HttpPost]
    [Route("reset-password")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> ResetPassword(PasswordResetEmailModel model)
    {
        // TODO: Implement password reset logic
        await accountService.ResetPasswordAsync(model);

        return NoContent();
    }

    [HttpPost]
    [Route("login-alert")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> SendLoginAlert(LoginAlertEmailModel model)
    {
        // TODO: Implement login alerts logic
        await accountService.SendLoginAlert(model);

        return NoContent();
    }

    [HttpPost]
    [Route("lockout")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> LockoutAccount(LockoutAccountEmailModel model)
    {
        // TODO: Implement account lockout logic
        await accountService.LockoutAccountAsync(model);

        return NoContent();
    }

    [HttpPost]
    [Route("close")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CloseAccount(CloseAccountEmailModel model)
    {
        // TODO: Implement account closure logic
        await accountService.CloseAccountAsync(model);

        return NoContent();
    }
}
