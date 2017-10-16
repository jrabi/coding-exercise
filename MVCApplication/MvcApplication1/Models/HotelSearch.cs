using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class HotelSearch
    {
        public string Destination { get; set; }
        public string TripStartDateFrom { get; set; }
        public string TripStartDateTo { get; set; }
        public string StayLength { get; set; }
        public string StarRatingFrom { get; set; }
    }
}