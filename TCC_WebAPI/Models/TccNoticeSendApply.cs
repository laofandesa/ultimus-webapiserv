using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccNoticeSendApply
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string FormNumber { get; set; }
        public string NoticeType { get; set; }
        public string SendType { get; set; }
        public string Title { get; set; }
        public string MainContent { get; set; }
    }
}
