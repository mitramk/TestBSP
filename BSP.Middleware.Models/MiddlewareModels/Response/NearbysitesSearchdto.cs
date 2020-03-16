using System.ComponentModel.DataAnnotations;

namespace BSP.Middleware.Models.MiddlewareModels.Response
{
    public class NearbySitesSearchdto
    {
        private string _searchTerm;

        public double? UserLatitude { get; set; }
        public double? UserLongitude { get; set; }
        [Required(ErrorMessage = "Please specify search term.")]
        [MaxLength(100, ErrorMessage = "Search term is too long.")]
        public string SearchTerm
        {
            get
            {
                return this._searchTerm;
            }
            set
            {
              

                this._searchTerm = value?.Trim();
                    //.RegexReplace(@"[^a-zA-Z0-9\s.,-]", " ") //replace special characters (except .,-) with white space
                    //.RegexReplace(@"\s+", " "); //remove extra white spaces
            }
        }
        [Required(ErrorMessage = "Please specify a valid order mode.")]
        public SiteSupportedOrderModes OrderMode { get; set; }
    }
}
