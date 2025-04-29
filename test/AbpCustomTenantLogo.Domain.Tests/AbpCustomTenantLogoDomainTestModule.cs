using Volo.Abp.Modularity;

namespace AbpCustomTenantLogo;

[DependsOn(
    typeof(AbpCustomTenantLogoDomainModule),
    typeof(AbpCustomTenantLogoTestBaseModule)
)]
public class AbpCustomTenantLogoDomainTestModule : AbpModule
{

}
