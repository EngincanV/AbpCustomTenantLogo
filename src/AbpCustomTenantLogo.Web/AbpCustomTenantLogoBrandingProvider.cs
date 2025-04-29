using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using AbpCustomTenantLogo.Localization;

namespace AbpCustomTenantLogo.Web;

[Dependency(ReplaceServices = true)]
public class AbpCustomTenantLogoBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AbpCustomTenantLogoResource> _localizer;

    public AbpCustomTenantLogoBrandingProvider(IStringLocalizer<AbpCustomTenantLogoResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
