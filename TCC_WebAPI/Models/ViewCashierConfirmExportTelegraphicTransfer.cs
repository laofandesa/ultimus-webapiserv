using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewCashierConfirmExportTelegraphicTransfer
    {
        public int Id { get; set; }
        public string 收款人 { get; set; }
        public string 收款账号 { get; set; }
        public string 开户行 { get; set; }
        public string 省 { get; set; }
        public string 市 { get; set; }
        public decimal? 付款金额 { get; set; }
        public string 付款账号 { get; set; }
        public string 付款方式 { get; set; }
        public string 用途 { get; set; }
        public string 接口代码 { get; set; }
        public string 地域标志 { get; set; }
        public string 跨行标志 { get; set; }
        public string 期望支付日期 { get; set; }
        public string 是否加急 { get; set; }
        public string 开户行行号 { get; set; }
        public string 会计凭证号 { get; set; }
        public string 领用人 { get; set; }
        public string 证件名称及号码 { get; set; }
        public string 附言 { get; set; }
        public string 是否对私付款 { get; set; }
        public string 行别 { get; set; }
        public string 联行行号 { get; set; }
        public string FormNumber { get; set; }
    }
}
