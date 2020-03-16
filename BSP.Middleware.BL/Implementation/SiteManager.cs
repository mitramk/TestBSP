using BSP.Middleware.Models.BSPModels.Response;
using BSP.Middleware.Models.MiddlewareModels.Response;
using BSP.Middleware.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BSP.Middleware.BL
{
    public class SiteManager : ISiteManager
    {
        private readonly ISiteService _bspService;
        public SiteManager(ISiteService BSPService) 
        {
            _bspService = BSPService;
        }

        public async Task<List<SiteResponse>> NearbySitesSearchAsAOOAsync(double searchLat, double searchLon)
        {
            var nearbySites = await _bspService.GetNearbySites(searchLat, searchLon);
            return ConvertBSPSiteToMiddlewareSite(nearbySites);
        }

        private List<SiteResponse> ConvertBSPSiteToMiddlewareSite(BSPSiteResponse bspSiteResponse)
        {
            List<SiteResponse> sitesResponse = new List<SiteResponse>();
            foreach (var site in bspSiteResponse.sites)
            {
                var siteResp = new SiteResponse();
                siteResp.SiteName = site.siteName;
                siteResp.EnterpriseUnitId = site.id;
                siteResp.Hours = new List<SiteHoursdto>();
                if (site.hours != null)
                {
                    foreach (var siteHours in site.hours)
                    {
                        var hours = new SiteHoursdto();
                        hours.OpeningTime = siteHours.open.time;
                        hours.ClosingTime = siteHours.close.time;
                        //TODO: Day of week
                    }
                }
                siteResp.Description = site.description;
                siteResp.AddressLine1 = site.address?.street;
                siteResp.City = site.address?.city;
                siteResp.State = site.address?.state;
                siteResp.VoicePhone = site.contact?.phoneNumber;
                
                sitesResponse.Add(siteResp);
            }
            return sitesResponse;
        }
    }
}
