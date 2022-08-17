using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewAskForLeave
    {
        public string TravelType { get; set; }
        public DateTime? TravelBeginDate { get; set; }
        public DateTime? TravelEndDate { get; set; }
        public string TravelPlace { get; set; }
        public int? Destination { get; set; }
        public string PersonLoginName { get; set; }
        public string PersonName { get; set; }
        public string UserIdentity { get; set; }
        public string Remark { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? FinishDate { get; set; }
    }
}
