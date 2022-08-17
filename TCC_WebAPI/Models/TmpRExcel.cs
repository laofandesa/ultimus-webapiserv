using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TmpRExcel
    {
        public int Id { get; set; }
        public string 类型 { get; set; }
        public string 类型名称 { get; set; }
        public string 申请人 { get; set; }
        public string 申请类型 { get; set; }
        public string 项目编号 { get; set; }
        public string 项目名称 { get; set; }
        public string 项目类型 { get; set; }
        public string 预计到账时间 { get; set; }
        public string 开出收据金额 { get; set; }
        public string 开出发票金额 { get; set; }
        public string 付款单位名称 { get; set; }
        public string 申请付款币种 { get; set; }
        public string 申请收款金额 { get; set; }
        public string 合同编号 { get; set; }
        public string 合同名称 { get; set; }
        public string 已收电汇金额 { get; set; }
        public string 已收汇票金额 { get; set; }
        public string 已收其他金额 { get; set; }
        public string 实收金额 { get; set; }
        public string 业主代扣额 { get; set; }
        public string 代扣税金 { get; set; }
        public string 发票票据编号 { get; set; }
        public string 收据票据编号 { get; set; }
        public string 客户编号 { get; set; }
        public string 客户名称 { get; set; }
        public string 申请人帐号 { get; set; }
    }
}
