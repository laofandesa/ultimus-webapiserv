using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccNotarizeApply
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyType { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string DocType { get; set; }
        public string NotarizeType { get; set; }
        public string NeedRz { get; set; }
        public string Rztype { get; set; }
        public string ProjectNo { get; set; }
        public string ProjectName { get; set; }
        public string UseCountry { get; set; }
        public string UseCountryId { get; set; }
        public string LauguageType { get; set; }
        public string LauguageTypeId { get; set; }
        public string FormNumber { get; set; }
        public int? NeedCount { get; set; }
        public string MainContent { get; set; }
    }
}
