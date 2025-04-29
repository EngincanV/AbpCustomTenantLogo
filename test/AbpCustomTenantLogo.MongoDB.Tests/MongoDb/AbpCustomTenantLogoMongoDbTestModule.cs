using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace AbpCustomTenantLogo.MongoDB;

[DependsOn(
    typeof(AbpCustomTenantLogoApplicationTestModule),
    typeof(AbpCustomTenantLogoMongoDbModule)
)]
public class AbpCustomTenantLogoMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = AbpCustomTenantLogoMongoDbFixture.GetRandomConnectionString();
        });
    }
}
