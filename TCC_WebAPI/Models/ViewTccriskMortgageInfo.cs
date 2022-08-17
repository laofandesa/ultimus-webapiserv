using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewTccriskMortgageInfo
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? Operate { get; set; }
        public string Person { get; set; }
        public string UserIdentity { get; set; }
        public string DutyCode { get; set; }
        public decimal? Amount { get; set; }
        public int DutyType { get; set; }
    }
}
