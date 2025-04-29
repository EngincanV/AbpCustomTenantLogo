using AbpCustomTenantLogo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpCustomTenantLogo.Web.Pages;

public abstract class AbpCustomTenantLogoPageModel : AbpPageModel
{
    protected AbpCustomTenantLogoPageModel()
    {
        LocalizationResourceType = typeof(AbpCustomTenantLogoResource);
    }
}
