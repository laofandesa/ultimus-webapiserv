using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewContractPaymentInfoNew
    {
        public string 项目号 { get; set; }
        public string 合同号 { get; set; }
        public double? 合同额原价 { get; set; }
        public decimal 已付款金额 { get; set; }
        public decimal 申请非信用证付款金额 { get; set; }
        public decimal 申请信用证付款金额 { get; set; }
        public decimal 已开信用证金额 { get; set; }
        public decimal 已支付信用证金额 { get; set; }
        public decimal 申请开立信用证金额 { get; set; }
        public double? 剩余未付款金额 { get; set; }
        public decimal? 剩余可用信用证金额 { get; set; }
        public double? 可申请非信用证付款金额 { get; set; }
    }
}
