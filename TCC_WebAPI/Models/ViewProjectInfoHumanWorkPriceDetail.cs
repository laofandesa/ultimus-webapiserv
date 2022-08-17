using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewProjectInfoHumanWorkPriceDetail
    {
        public string ProjId { get; set; }
        public string Iyear { get; set; }
        public string DeptName { get; set; }
        public int Flag { get; set; }
        public double? Ihours { get; set; }
        public double? Unitprice { get; set; }
        public double? Amount { get; set; }
    }
}
