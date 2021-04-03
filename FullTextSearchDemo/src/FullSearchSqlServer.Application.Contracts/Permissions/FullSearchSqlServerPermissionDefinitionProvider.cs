using FullSearchSqlServer.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FullSearchSqlServer.Permissions
{
    public class FullSearchSqlServerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(FullSearchSqlServerPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(FullSearchSqlServerPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<FullSearchSqlServerResource>(name);
        }
    }
}
