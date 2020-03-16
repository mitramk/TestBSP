using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BSP.Middleware.Models.BSPModels.Response;
using Newtonsoft.Json;

namespace BSP.Middleware.Services
{
    public class SiteServiceImpl : ISiteService
    {
        //TODO: get from config
        private readonly string _baseUrl = "https://gateway-staging.ncrcloud.com/";
        private readonly HttpClient _httpClient;

        public SiteServiceImpl()
        {
            //TODO: move to helper
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_baseUrl)
            };
            _httpClient.DefaultRequestHeaders.Add("nep-application-key", "8a0386026f474f18016ff12f947d009a");

            _httpClient.DefaultRequestHeaders.Add("nep-organization", "/teams/internal-teams/ps-digital-services/");
            var byteArray = Encoding.ASCII.GetBytes("acct:ps-digital-services@ps-digital-services-service-account:^r5409H@Tf6gD55t");
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }

        public async Task<BSPSiteResponse> GetNearbySites(double latitude, double longitude, int radius = 10000, int numSites = 500, Array[] customAttributes = null, string group = null)
        {
            var urlBuilder = new StringBuilder(_baseUrl);
            urlBuilder.Append($"site/sites/find-nearby/{latitude},{longitude}?radius={radius}&numSites={numSites}");
            HttpResponseMessage response = await _httpClient.GetAsync(urlBuilder.ToString());

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception();

            string jsonString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BSPSiteResponse>(jsonString);
        }
    }
}
