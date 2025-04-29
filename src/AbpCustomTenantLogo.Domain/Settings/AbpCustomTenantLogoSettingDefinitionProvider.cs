using Volo.Abp.Settings;

namespace AbpCustomTenantLogo.Settings;

public class AbpCustomTenantLogoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpCustomTenantLogoSettings.MySetting1));
    }
}
