using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.SettingManagement;

namespace AbpCustomTenantLogo
{
    public class CustomTenantLogoAppService : ApplicationService, ICustomTenantLogoAppService
    {
        private readonly ISettingManager _settingManager;

        public CustomTenantLogoAppService(ISettingManager settingManager)
        {
            _settingManager = settingManager;
        }
        public async Task UpdateTenantLogoUrlAsync(Guid? tenantId, string tenantLogoUrl)
        {
            //not host tenant, and if the tenantId is not the current tenant id, throw an exception
            if(CurrentTenant.Id.HasValue && tenantId != CurrentTenant.Id.Value)
            {
                throw new UserFriendlyException("You are not allowed to update this tenant's logo.");
            }

            await _settingManager.SetForCurrentTenantAsync("CustomTenantLogo", tenantLogoUrl);
        }
    }
}