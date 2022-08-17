using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAbroadWorkVisaRecord
    {
        public int Id { get; set; }
        public string UserKey { get; set; }
        public string Name { get; set; }
        public string CompName { get; set; }
        public string DeptNo { get; set; }
        public string DeptName { get; set; }
        public string FormNumber { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectInfo { get; set; }
        public string WorkVisaStatus { get; set; }
        public string ProjectRole { get; set; }
        public string WorkVisaCode { get; set; }
        public string WorkVisaSign { get; set; }
        public string WorkVisaValid { get; set; }
        public int? WorkVisaMonth { get; set; }
        public string NewWorkVisaValid { get; set; }
        public int? WorkVisaNum { get; set; }
        public string Country { get; set; }
        public string Remark { get; set; }
    }
}
