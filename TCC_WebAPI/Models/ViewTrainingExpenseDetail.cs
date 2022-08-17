using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewTrainingExpenseDetail
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? 年度 { get; set; }
        public string 部门 { get; set; }
        public string 姓名 { get; set; }
        public DateTime? 培训开始时间 { get; set; }
        public DateTime? 培训结束时间 { get; set; }
        public int? 培训时间天 { get; set; }
        public int? 培训时间小时 { get; set; }
        public string 培训内容 { get; set; }
        public string 培训具体地点 { get; set; }
        public string 主办单位 { get; set; }
        public decimal 培训费用 { get; set; }
        public decimal? 差旅费 { get; set; }
        public string 交通工具 { get; set; }
        public string 表单编号 { get; set; }
        public string 部门负责人 { get; set; }
        public string 主管部门审核 { get; set; }
        public string 主管部门负责人 { get; set; }
        public DateTime? 报销时间 { get; set; }
        public string Linkproname { get; set; }
    }
}
