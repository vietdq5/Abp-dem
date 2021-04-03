using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace FullSearchSqlServer.Pages
{
    public class Index_Tests : FullSearchSqlServerWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
