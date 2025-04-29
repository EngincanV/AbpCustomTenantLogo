using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpCustomTenantLogo.Pages;

[Collection(AbpCustomTenantLogoTestConsts.CollectionDefinitionName)]
public class Index_Tests : AbpCustomTenantLogoWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
