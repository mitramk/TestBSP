using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BSP.Middleware.BL;
using BSP.Middleware.Models.MiddlewareModels.Response;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace BSP.Middleware.Tests
{
    public class StartupMock : Startup
    {
        private Mock<ISiteManager> MockSiteManager;

        public StartupMock(IConfiguration configuration) : base(configuration)
        {
        }

        public override void ConfigureManagers(IServiceCollection services)
        {
            MockSiteManager = new Mock<ISiteManager>();
            SetupGetSiteSuccessResponse();
            SetupGetSiteNotFoundResponse();
            services.AddSingleton(MockSiteManager.Object);
        }

        private void SetupGetSiteSuccessResponse()
        {
            var siteResponseSuccess = new List<SiteResponse>();

            siteResponseSuccess.Add(new SiteResponse()
            {
                SiteId = 1,
                SiteName = "TestSite"
            });
            MockSiteManager.Setup(x => x.NearbySitesSearchAsAOOAsync(34, 35)).Returns(Task.FromResult(siteResponseSuccess));
        }

        private void SetupGetSiteNotFoundResponse()
        {
            List<SiteResponse> siteResponseSuccess = null;
            MockSiteManager.Setup(x => x.NearbySitesSearchAsAOOAsync(0, 0)).Returns(Task.FromResult(siteResponseSuccess));
        }
    }
}
