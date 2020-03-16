using System;

namespace BSP.Middleware.Models.MiddlewareModels.Response
{
    public class SiteSpecialEventdto
    {
        public int? SpecialEventId { get; set; }
        public DateTime? SpecialEventStartDate { get; set; }
        public string Name { get; set; }
        public DateTime? OpeningTime { get; set; }
        public DateTime? ClosingTime { get; set; }
        public bool? IsClosed { get; set; }
        public DateTime? SpecialEventEndDate { get; set; }
        public bool? IsCompanyWide { get; set; }
        public string SpecialEventPurpose { get; set; }
    }
}
