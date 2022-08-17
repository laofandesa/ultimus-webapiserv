using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class KqgcTest
    {
        public string 状态 { get; set; }
        public string 身份证号 { get; set; }
        public string 姓名 { get; set; }
        public DateTime 起始日期 { get; set; }
        public DateTime 终止日期 { get; set; }
        public string 事由 { get; set; }
        public string 申请单号 { get; set; }
        public string 关联单号 { get; set; }
        public string 审批人 { get; set; }
        public DateTime? 审批时间 { get; set; }
        public DateTime? 申请时间 { get; set; }
    }
}
