using System.Threading.Tasks;
using AbpCustomTenantLogo.Web.Components;
using Volo.Abp.SettingManagement.Web.Pages.SettingManagement;

namespace AbpCustomTenantLogo.Web
{
    public class CustomTenantLogoSettingPageContributor : ISettingPageContributor
    {
        public Task<bool> CheckPermissionsAsync(SettingPageCreationContext context)
        {
            //we can check a permission in here, but for now just assume the permission is granted.
            //TODO: check a permission in here & also it should just should be shown by the host admin and admin of a tenant not by everyone
            return Task.FromResult(true);
        }

        public Task ConfigureAsync(SettingPageCreationContext context)
        {
            context.Groups.Add(
                new SettingPageGroup(
                    id: "CustomTenantLogoWrapper",
                    displayName: "Custom Tenant Logo",
                    typeof(CustomTenantLogoViewComponent)
                )
            );

            return Task.CompletedTask;
        }
    }
}