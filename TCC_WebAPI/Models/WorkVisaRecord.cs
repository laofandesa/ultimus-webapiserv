using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class WorkVisaRecord
    {
        public int Id { get; set; }
        public string ApplyLogin { get; set; }
        public string FormNumber { get; set; }
        public int? ProcessStatus { get; set; }
        public string DeptNo { get; set; }
        public string DeptName { get; set; }
        public string Name { get; set; }
        public string UserKey { get; set; }
        public int? AbroadSpecType { get; set; }
        public string ApplyProjectNo { get; set; }
        public string ApplyProjectName { get; set; }
        public string ApplyProjectInfo { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDeptName { get; set; }
        public string ProjectRole { get; set; }
        public string WorkVisaCode { get; set; }
        public string WorkVisaStatus { get; set; }
        public DateTime? WorkVisaSign { get; set; }
        public DateTime? WorkVisaValid { get; set; }
        public int? WorkVisaMonth { get; set; }
        public string NewWorkVisaValid { get; set; }
        public int? WorkVisaNum { get; set; }
        public string Country { get; set; }
    }
}
