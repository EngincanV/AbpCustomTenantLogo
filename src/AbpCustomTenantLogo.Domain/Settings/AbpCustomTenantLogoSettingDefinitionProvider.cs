using AbpCustomTenantLogo.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Settings;

namespace AbpCustomTenantLogo.Settings;

public class AbpCustomTenantLogoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        context.Add(new SettingDefinition(
            name: "CustomTenantLogo",
            defaultValue: "",
            displayName: L("Custom Tenant Logo"),
            isVisibleToClients: true
        ));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpCustomTenantLogoResource>(name);
    }
}