using Volo.Abp.Settings;

namespace FullSearchSqlServer.Settings
{
    public class FullSearchSqlServerSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(FullSearchSqlServerSettings.MySetting1));
        }
    }
}
