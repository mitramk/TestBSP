using BSP.Middleware.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSP.Middleware.Models.MiddlewareModels.Response
{
    public class SiteResponse
    {
        public int SiteId { get; set; }
        public string ExternalId { get; set; }
        public string EnterpriseUnitId { get; set; }
        public string SiteName { get; set; }

        public string Description { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal { get; set; }
        public string VoicePhone { get; set; }
        public string FAXPhone { get; set; }
        public int WebDesignId { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsLoyaltyEnabled { get; set; }
        public bool IsStoredValueCardEnabled { get; set; }
        public int? TimeOffsetHours { get; set; }
        public int? TimeOffsetMinutes { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double? UserDistance { get; set; }
        public DistanceUnit? DistanceUnit { get; set; }
        /// <summary>
        /// List open hours for every day in the week. One element of the list represents one day of the week.
        /// </summary>
        public List<SiteHoursdto> Hours { get; set; }
        /// <summary>
        /// List of dates that represent special events with their descriptions and specified special working hours.
        /// </summary>
        public List<SiteSpecialEventdto> SpecialEvents { get; set; }
        /// <summary>
        /// Order modes available at this site.
        /// </summary>
        public SiteSupportedOrderModes SupportedOrderModes { get; set; }
        public List<string> OrderTypesSupported { get; set; }
        /// <summary>
        /// True if site is currently open.
        /// </summary>
        public bool IsWorking { get; set; }
        public string OpenAt { get; set; }
        public double DeliveryRange { get; set; }
        public bool? InDeliveryZone { get; set; }
        public SiteStatusUnified SiteStatusUnified { get; set; }
        /// <summary>
        /// Specifies if catering items are required for delivery mode.
        /// </summary>
        public bool IsCateringRequiredInDelivery { get; set; }
        /// <summary>
        /// Minimum total amount required for catering pickup mode.
        /// </summary>
        public double CateringPickupMinOrderTotalAmount { get; set; }
        /// <summary>
        /// Minimum total amount required for catering delivery mode.
        /// </summary>
        public double CateringDeliveryMinOrderTotalAmount { get; set; }

        public bool IsOrderTypeSupported(SiteSupportedOrderModes orderMode)
        {
            return this.OrderTypesSupported.Contains(orderMode.ToString());
        }
    }
}
