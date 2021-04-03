using FullSearchSqlServer.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace FullSearchSqlServer.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class FullSearchSqlServerPageModel : AbpPageModel
    {
        protected FullSearchSqlServerPageModel()
        {
            LocalizationResourceType = typeof(FullSearchSqlServerResource);
        }
    }
}