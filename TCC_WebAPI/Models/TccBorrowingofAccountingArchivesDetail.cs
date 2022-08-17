using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBorrowingofAccountingArchivesDetail
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string ApplyLoginName { get; set; }
        public string ApplyRealName { get; set; }
        public string ApplyUseridentity { get; set; }
        public string AcctYear { get; set; }
        public string CheckDate { get; set; }
        public int? Vchrnum { get; set; }
        public DateTime? VchrDate { get; set; }
        public string VchrContent { get; set; }
        public string Remark { get; set; }
        public int? ConfirmStatus { get; set; }
        public DateTime? ConfirmDate { get; set; }
    }
}
