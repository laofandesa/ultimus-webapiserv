using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewCashierConfirmExportCheque
    {
        public int Id { get; set; }
        public string 收款单位名称 { get; set; }
        public decimal? 金额 { get; set; }
        public string 用途 { get; set; }
        public string FormNumber { get; set; }
    }
}
