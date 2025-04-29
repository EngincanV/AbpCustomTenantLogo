using AbpCustomTenantLogo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpCustomTenantLogo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpCustomTenantLogoController : AbpControllerBase
{
    protected AbpCustomTenantLogoController()
    {
        LocalizationResource = typeof(AbpCustomTenantLogoResource);
    }
}
