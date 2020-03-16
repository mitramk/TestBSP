using BSP.Middleware.BL;
using BSP.Middleware.Models.BSPModels.Response;
using BSP.Middleware.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BSP.Middleware.Tests.BLTests
{
    public class SiteManagerTest
    {
        [Fact]
        public async Task TestGetNearbySitesSuccess()
        {
            var MockSiteService = new Mock<ISiteService>();
            var response = new BSPSiteResponse();
           var sites = new List<Site>();
            var site = new Site();
            site.siteName = "test";
            var hours = new List<Hour>();
            var hour = new Hour();
            var open= new Open();
            open.day = "SUNDAY";
            open.time = "10:00:00";
            var close = new Close();
            close.day = "SUNDAY";
            close.time = "18:00:00";
            hour.open = open;
            hour.close = close;
            hours.Add(hour);
            site.hours = hours.ToArray();
            sites.Add(site);
            response.sites = sites.ToArray();
            MockSiteService.Setup(x => x.GetNearbySites(It.IsAny<double>(), It.IsAny<double>(),10000,500,null,null)).Returns(Task.FromResult(response));
            var siteManager = new SiteManager(MockSiteService.Object);
            var actual = await siteManager.NearbySitesSearchAsAOOAsync(10, 10);
            Assert.Equal("test", actual[0].SiteName);

        }

    }
}
