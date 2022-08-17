using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDraftInfoImport1Temp
    {
        public int Id { get; set; }
        public int? Flag { get; set; }
        public string CreatorUserLoginName { get; set; }
        public string CreatorUserName { get; set; }
        public string RequestSfzh { get; set; }
        public DateTime? CreateDate { get; set; }
        public string DeptName { get; set; }
        public string DeptCode { get; set; }
        public string DraftType { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string SourceName { get; set; }
        public string SourceCode { get; set; }
        public string FundsProjectCode { get; set; }
        public string FundsProjectName { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int? Attachment { get; set; }
        public int? FId { get; set; }
        public string FFormNumber { get; set; }
        public string RequestTelephone { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public int? RequestFlag { get; set; }
        public string PartBid { get; set; }
        public string PartBname { get; set; }
        public decimal? Total { get; set; }
        public decimal? ReceiptAmount { get; set; }
        public string SignCode { get; set; }
        public string SignName { get; set; }
    }
}
