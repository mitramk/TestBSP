using System;

namespace BSP.Middleware.Models.MiddlewareModels.Response
{
    public class SiteHoursdto
    {
        private string _openingTime;
        private string _closingTime;

        public DayOfWeek DayOfWeek { get; set; }
        public string OpeningTime
        {
            get
            {
                return DateTime.Parse(this._openingTime).ToString("hh:mm tt"); 
            }
            set
            {
                this._openingTime = value;
            }
        }
        
        public string ClosingTime
        {
            get
            {
                return DateTime.Parse(this._closingTime).ToString("hh:mm tt");
            }
            set
            {
                this._closingTime = value;
            }
        }

        public bool IsClosed { get; set; }
    }
}
