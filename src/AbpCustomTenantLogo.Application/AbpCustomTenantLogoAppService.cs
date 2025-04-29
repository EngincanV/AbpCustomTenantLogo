using AbpCustomTenantLogo.Localization;
using Volo.Abp.Application.Services;

namespace AbpCustomTenantLogo;

/* Inherit your application services from this class.
 */
public abstract class AbpCustomTenantLogoAppService : ApplicationService
{
    protected AbpCustomTenantLogoAppService()
    {
        LocalizationResource = typeof(AbpCustomTenantLogoResource);
    }
}
