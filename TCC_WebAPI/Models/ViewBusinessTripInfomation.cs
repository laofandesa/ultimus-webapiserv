using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBusinessTripInfomation
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string IdcardDno { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? TotalDays { get; set; }
        public string TravelAdress { get; set; }
    }
}
