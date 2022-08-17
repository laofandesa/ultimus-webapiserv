using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewTelephoneSubsidyInfo
    {
        public string RealName { get; set; }
        public string UserIdentify { get; set; }
        public int? Flag { get; set; }
        public decimal? Amount { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
    }
}
