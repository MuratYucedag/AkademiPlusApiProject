using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkademiPlusApiProject.RapidApi.Models
{
    public class RapidApiBookingHotelViewModel
    {
        public Result[] result { get; set; }
        public class Result
        {
            public float? review_score { get; set; }
            public string hotel_name { get; set; }
        }
    }
}