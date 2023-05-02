using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkademiPlusApiProject.RapidApi.Models
{
    public class RapidApiImdbViewModel
    {
            public int rank { get; set; }
            public string title { get; set; }
            public string thumbnail { get; set; }
            public string rating { get; set; }
            public string id { get; set; }
            public int year { get; set; }
            public string image { get; set; }
            public string description { get; set; }
            public string trailer { get; set; }
        }
    }