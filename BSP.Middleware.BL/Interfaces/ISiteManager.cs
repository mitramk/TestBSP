using BSP.Middleware.Models.MiddlewareModels.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BSP.Middleware.BL
{
    public interface ISiteManager
    {
        Task<List<SiteResponse>> NearbySitesSearchAsAOOAsync(double searchLat, double searchLon);
    }
}
