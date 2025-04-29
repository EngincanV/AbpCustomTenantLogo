using AbpCustomTenantLogo.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpCustomTenantLogo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCustomTenantLogoMongoDbModule),
    typeof(AbpCustomTenantLogoApplicationContractsModule)
)]
public class AbpCustomTenantLogoDbMigratorModule : AbpModule
{
}
