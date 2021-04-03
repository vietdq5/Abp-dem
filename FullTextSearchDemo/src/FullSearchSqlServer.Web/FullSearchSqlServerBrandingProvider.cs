using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace FullSearchSqlServer.Web
{
    [Dependency(ReplaceServices = true)]
    public class FullSearchSqlServerBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "FullSearchSqlServer";
    }
}
