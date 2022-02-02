using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ToastDemo.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly INotyfService _toastNotification;

        public PrivacyModel(ILogger<PrivacyModel> logger, INotyfService toastNotification)
        {
            _logger = logger;
            _toastNotification = toastNotification;
        }

        public void OnGet()
        {
            // Default Notifications
            _toastNotification.Success("A success for christian-schou.dk");
            _toastNotification.Information("Here is an info toast - closes in 6 seconds.", 6);
            _toastNotification.Warning("Be aware, here is a warning toast.");
            _toastNotification.Error("Ouch - An error occured. This message closes in 4 seconds.", 4);

            // Custom Notifications
            _toastNotification.Custom("Here is a message for you - closes in 8 seconds.", 8, "#602AC3", "fa fa-envelope-o");
            _toastNotification.Custom("Please check the settings for your profile - closes in 6 seconds.", 6, "#0c343d", "fa fa-user");
        }
    }
}