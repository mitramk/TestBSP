using BSP.Middleware.Models.BSPModels.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BSP.Middleware.Services
{
    public interface ISiteService
    {
        Task<BSPSiteResponse> GetNearbySites(double latitude, double longitude, int radius = 10000, int numSites = 500, Array[] customAttributes = null, string group = null);
    }
}
