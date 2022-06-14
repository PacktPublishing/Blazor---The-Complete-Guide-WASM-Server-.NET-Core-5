using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HiddenVilla_Server.Areas.Identity.Pages.Account.Manage
{
    public class ShowRecoveryCodesModel : PageModel
    {
        [TempData]
        public string[] RecoveryCodes { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public IActionResult OnGet() => RecoveryCodes == null || RecoveryCodes.Length == 0
            ? RedirectToPage("./TwoFactorAuthentication")
            : Page();
    }
}
