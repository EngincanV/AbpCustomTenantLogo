using System.Threading.Tasks;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;
using Volo.Abp.SettingManagement;
using Volo.Abp.Threading;

namespace AbpCustomTenantLogo.Web;

[Dependency(ReplaceServices = true)]
public class AbpCustomTenantLogoBrandingProvider : DefaultBrandingProvider
{
    private readonly ISettingManager _settingManager;
    private readonly ICurrentTenant _currentTenant;

    public AbpCustomTenantLogoBrandingProvider(ISettingManager settingManager, ICurrentTenant currentTenant)
    {
        _settingManager = settingManager;
        _currentTenant = currentTenant;
    }

    public override string? LogoUrl => AsyncHelper.RunSync(GetTenantLogoUrlAsync) ?? base.LogoUrl;

    public async Task<string?> GetTenantLogoUrlAsync()
    {
        //add caching and other logic here!!!
        var tenantId = _currentTenant.Id;
        if(!tenantId.HasValue)
        {
            return null;
        }

        var customTenantLogoUrl = await _settingManager.GetOrNullForCurrentTenantAsync("CustomTenantLogo");
        return string.IsNullOrWhiteSpace(customTenantLogoUrl) ? null : customTenantLogoUrl;
    }
}
