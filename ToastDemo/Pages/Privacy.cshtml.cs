using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;

namespace ToastDemo.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly IToastNotification _toastNotification;

        public PrivacyModel(ILogger<PrivacyModel> logger, IToastNotification toastNotification)
        {
            _logger = logger;
            _toastNotification = toastNotification;
        }

        public void OnGet()
        {
            // Info Toast
            _toastNotification.AddInfoToastMessage("You got redirected to the privacy policy.");
        }
    }
}