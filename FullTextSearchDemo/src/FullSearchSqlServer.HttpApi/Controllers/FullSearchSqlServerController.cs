using FullSearchSqlServer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FullSearchSqlServer.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class FullSearchSqlServerController : AbpController
    {
        protected FullSearchSqlServerController()
        {
            LocalizationResource = typeof(FullSearchSqlServerResource);
        }
    }
}