using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewTccTravelItineraryInfo
    {
        public string 报销单号 { get; set; }
        public string 出差单号 { get; set; }
        public string ExpenseWhere { get; set; }
        public string StrokeNumber { get; set; }
        public string TicketingCompany { get; set; }
        public string Name { get; set; }
    }
}
