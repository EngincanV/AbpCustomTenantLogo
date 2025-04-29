using System.Threading.Tasks;

namespace AbpCustomTenantLogo.Data;

public interface IAbpCustomTenantLogoDbSchemaMigrator
{
    Task MigrateAsync();
}
