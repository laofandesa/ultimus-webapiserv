using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewCashierConfirmExportCash
    {
        public int Id { get; set; }
        public string 收款人 { get; set; }
        public string 公务卡号 { get; set; }
        public decimal? 金额 { get; set; }
        public string FormNumber { get; set; }
        public int? Location { get; set; }
    }
}
