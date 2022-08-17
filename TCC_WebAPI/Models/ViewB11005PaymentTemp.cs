using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewB11005PaymentTemp
    {
        public long Rss { get; set; }
        public string 申请日期 { get; set; }
        public string 申请人 { get; set; }
        public string 付款节点 { get; set; }
        public decimal? 应付工程款 { get; set; }
        public decimal? 票据金额 { get; set; }
        public decimal? 扣款金额 { get; set; }
        public decimal? 扣税金额 { get; set; }
        public decimal? RequestAmount { get; set; }
        public string 付款币种 { get; set; }
        public decimal? 实际付款金额 { get; set; }
        public decimal? 折人民币金额 { get; set; }
        public string 收款单位名称 { get; set; }
        public string 付款操作人 { get; set; }
        public int? RequestPayCategory { get; set; }
        public int? Ppid { get; set; }
        public string 付款方式 { get; set; }
        public string 单据编号 { get; set; }
        public decimal? 代扣增值税 { get; set; }
        public decimal? 代扣其他税 { get; set; }
        public decimal? 罚款金额 { get; set; }
        public decimal? 付增值税 { get; set; }
        public decimal? AccountPaid { get; set; }
        public decimal? 申请金额 { get; set; }
        public decimal? 代扣水电费 { get; set; }
        public decimal? 代扣农民工工资 { get; set; }
        public int? Flag { get; set; }
        public double? 合同总额原币 { get; set; }
        public double? Tax { get; set; }
        public decimal? OtherBuy { get; set; }
        public decimal? 折主合同金额 { get; set; }
        public decimal? MainExchange { get; set; }
        public string 代购主合同币种 { get; set; }
        public int? OtherBuyFlag { get; set; }
        public int? MainContractFlag { get; set; }
        public long? Id { get; set; }
    }
}
