using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpCustomTenantLogo.Data;

/* This is used if database provider does't define
 * IAbpCustomTenantLogoDbSchemaMigrator implementation.
 */
public class NullAbpCustomTenantLogoDbSchemaMigrator : IAbpCustomTenantLogoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
