using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccArchivesApply
    {
        public int Id { get; set; }
        public string ApplyDate { get; set; }
        public string FormNumber { get; set; }
        public string DocSource { get; set; }
        public string DocType { get; set; }
        public string DocKind { get; set; }
        public string ApplyName { get; set; }
        public string ApplyLoginName { get; set; }
        public string ApplyDeptName { get; set; }
        public string ApplyDeptNo { get; set; }
        public string SecLevel { get; set; }
        public string DocTitle { get; set; }
        public string DocNo { get; set; }
        public string SendDate { get; set; }
        public string PaperCount { get; set; }
        public string InfoOpen { get; set; }
        public string DocFileId { get; set; }
        public string AttFileId { get; set; }
        public string ArchiveDate { get; set; }
        public string SaveType { get; set; }
        public string ArchiveNo { get; set; }
        public string ArchivePlace { get; set; }
        public string Remark { get; set; }
        public string IncidentNo { get; set; }
        public string FromProcessName { get; set; }
        public string ThirdPart { get; set; }
        public string ProcessStatus { get; set; }
        public string IsAgree { get; set; }
        public string DisAgreeReason { get; set; }
    }
}
