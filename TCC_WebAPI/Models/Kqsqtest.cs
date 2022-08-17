using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class Kqsqtest
    {
        public string 身份证号 { get; set; }
        public string 请假类别 { get; set; }
        public DateTime? 申请日期 { get; set; }
        public DateTime 起始时间 { get; set; }
        public DateTime 结束时间 { get; set; }
        public string 请假事由 { get; set; }
        public string 部门领导 { get; set; }
        public string 部门领导意见 { get; set; }
        public string 单位领导 { get; set; }
        public string 单位领导意见 { get; set; }
        public string 审批结果 { get; set; }
        public DateTime? 审批时间 { get; set; }
        public string 单号 { get; set; }
        public string 状态 { get; set; }
    }
}
