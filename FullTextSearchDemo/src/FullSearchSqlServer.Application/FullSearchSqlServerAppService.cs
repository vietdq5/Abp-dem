using System;
using System.Collections.Generic;
using System.Text;
using FullSearchSqlServer.Localization;
using Volo.Abp.Application.Services;

namespace FullSearchSqlServer
{
    /* Inherit your application services from this class.
     */
    public abstract class FullSearchSqlServerAppService : ApplicationService
    {
        protected FullSearchSqlServerAppService()
        {
            LocalizationResource = typeof(FullSearchSqlServerResource);
        }
    }
}
