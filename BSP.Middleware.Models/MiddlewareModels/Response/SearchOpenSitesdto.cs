using System.ComponentModel.DataAnnotations;

namespace BSP.Middleware.Models.MiddlewareModels.Response
{
    public class SearchOpenSitesdto
    {
        [Required(ErrorMessage = "Please specify search term.")]
        public string SearchTerm { get; set; }
        [Required(ErrorMessage = "Please specify a valid order mode.")]
        public SiteSupportedOrderModes OrderMode { get; set; }
    }
}