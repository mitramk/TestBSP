
using System.ComponentModel.DataAnnotations;

namespace BSP.Middleware.Models.MiddlewareModels.Response
{
    public class NearbySitesGeodto
    {
        [Required(ErrorMessage = "Latitude must be specified.")]
        public double Latitude { get; set; }
        [Required(ErrorMessage = "Longitude must be specified.")]
        public double Longitude { get; set; }
        [Required(ErrorMessage = "Order mode must be specified.")]
        public SiteSupportedOrderModes OrderMode { get; set; }

    }

    public enum SiteSupportedOrderModes
    {
        Pickup = 1,
        Delivery = 2,
        CurbSide = 4,
        SVCDeposit = 8,
        DineIn = 16,
        Unknown = 32,
        Undefined = 128,
        DriveThrough = 256
    }
}
