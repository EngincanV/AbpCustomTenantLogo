using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace AbpCustomTenantLogo
{
    public interface ICustomTenantLogoAppService : IApplicationService
    {
        Task UpdateTenantLogoUrlAsync(Guid? tenantId, string tenantLogoUrl);
    }
}