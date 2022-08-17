using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewTripStandard
    {
        public string DomesticOverseaName { get; set; }
        public int? DomesticOversea { get; set; }
        public string PostCategory { get; set; }
        public string Post { get; set; }
        public string Train { get; set; }
        public string AirPlane { get; set; }
        public string SteamShip { get; set; }
        public decimal? Regions { get; set; }
        public string TrainName { get; set; }
        public string AirName { get; set; }
        public string SteamListName { get; set; }
    }
}
