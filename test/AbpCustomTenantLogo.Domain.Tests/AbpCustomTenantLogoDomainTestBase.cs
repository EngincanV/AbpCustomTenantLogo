using Volo.Abp.Modularity;

namespace AbpCustomTenantLogo;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpCustomTenantLogoDomainTestBase<TStartupModule> : AbpCustomTenantLogoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
