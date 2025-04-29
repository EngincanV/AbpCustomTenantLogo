using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.SettingManagement;

namespace AbpCustomTenantLogo.Web.Components
{
    public class CustomTenantLogoViewComponent : AbpViewComponent
    {
        private readonly ISettingManager _settingManager;

        public CustomTenantLogoViewComponent(ISettingManager settingManager)
        {
            _settingManager = settingManager;
        }

        public virtual async Task<IViewComponentResult> InvokeAsync()
        {
            var customTenantLogoSetting = await _settingManager.GetOrNullForCurrentTenantAsync("CustomTenantLogo");

            return View("~/Components/Default.cshtml", new CustomTenantLogoViewModel
            {
                CustomTenantLogoUrl = customTenantLogoSetting
            });
        }
    }

    public class CustomTenantLogoViewModel
    {
        public string CustomTenantLogoUrl { get; set; }
    }
}