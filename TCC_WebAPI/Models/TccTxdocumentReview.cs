﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTxdocumentReview
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string SendDocNo { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public string DocTitle { get; set; }
        public int? DocNum { get; set; }
        public string DocType { get; set; }
        public string SendType { get; set; }
        public string ApplyPhone { get; set; }
        public string SubDeptNo { get; set; }
        public string DocFileId { get; set; }
        public string AttFileId { get; set; }
        public string FormNumber { get; set; }
        public string OptionDept { get; set; }
        public DateTime? SendDocDate { get; set; }
        public int? SubDeptNum { get; set; }
    }
}
