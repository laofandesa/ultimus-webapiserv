using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewProjectBudgetInfoTemp
    {
        public string 项目号 { get; set; }
        public string 项目名称 { get; set; }
        public string 费用类型 { get; set; }
        public decimal? 预算金额 { get; set; }
        public decimal? 已发生金额 { get; set; }
        public decimal? 剩余预算 { get; set; }
        public decimal? 流程中金额 { get; set; }
        public decimal? 提交时验证金额 { get; set; }
    }
}
