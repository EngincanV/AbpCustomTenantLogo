using Microsoft.AspNetCore.Builder;
using AbpCustomTenantLogo;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("AbpCustomTenantLogo.Web.csproj"); 
await builder.RunAbpModuleAsync<AbpCustomTenantLogoWebTestModule>(applicationName: "AbpCustomTenantLogo.Web");

public partial class Program
{
}
