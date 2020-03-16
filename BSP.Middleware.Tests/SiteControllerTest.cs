using BSP.Middleware.Models.MiddlewareModels.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace BSP.Middleware.Tests
{
    public class SiteControllerTest : IClassFixture<TestFixture<StartupMock>>
    {
        private HttpClient Client;

        public SiteControllerTest(TestFixture<StartupMock> fixture)
        {
            Client = fixture.Client;
        }

        [Fact]
        public async Task TestPostGetSiteAsync_Success()
        {
            //Arrange
            var request = new
            {
                Url = "/api/Sites/GetSite",
                Body = new
                {
                    Latitude = 34,
                    Longitude = 35
                }
            };

            // Act
            var response = await Client.PostAsync(request.Url, ContentHelper.GetStringContent(request.Body));
            var value = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<SiteResponse>>(value);

            //Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal("TestSite", result[0].SiteName);
        }

        [Fact]
        public async Task TestPostGetSiteAsync_NotFound()
        {
            //Arrange
            var request = new
            {
                Url = "/api/Sites/GetSite",
                Body = new
                {
                    Latitude = 0,
                    Longitude = 0
                }
            };

            // Act
            var response = await Client.PostAsync(request.Url, ContentHelper.GetStringContent(request.Body));

            //Assert            
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }


    }
}
