using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BSP.Middleware.BL;
using BSP.Middleware.Models.MiddlewareModels.Response;
using Microsoft.AspNetCore.Mvc;

namespace BSP.Middleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SitesController : ControllerBase
    {
        private readonly ISiteManager _siteManager;
        public SitesController(ISiteManager siteManager)
        {
            _siteManager = siteManager;
        }
        // Post api/values
        [HttpPost]
        [Route("GetSite")]
        public async Task<ActionResult<List<SiteResponse>>> NearbySitesByGeolocation([FromBody]NearbySitesGeodto model)
        {
            List<SiteResponse> sites = new List<SiteResponse>();

            sites = await _siteManager.NearbySitesSearchAsAOOAsync(model.Latitude, model.Longitude);

            if (sites == null)
                return NotFound();

            return Ok(sites);
        }

    }
}