using AbpCustomTenantLogo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace AbpCustomTenantLogo.Permissions;

public class AbpCustomTenantLogoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpCustomTenantLogoPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpCustomTenantLogoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpCustomTenantLogoResource>(name);
    }
}
