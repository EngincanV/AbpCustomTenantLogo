using Volo.Abp.Modularity;

namespace AbpCustomTenantLogo;

[DependsOn(
    typeof(AbpCustomTenantLogoApplicationModule),
    typeof(AbpCustomTenantLogoDomainTestModule)
)]
public class AbpCustomTenantLogoApplicationTestModule : AbpModule
{

}
