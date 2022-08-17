using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAbroadWorkVisaUser
    {
        public int Id { get; set; }
        public string CompName { get; set; }
        public string DeptNo { get; set; }
        public string DeptName { get; set; }
        public string Pinyin { get; set; }
        public string Name { get; set; }
        public int? Sex { get; set; }
        public string UserKey { get; set; }
        public DateTime? BornDate { get; set; }
        public string JobTitle { get; set; }
        public string TitleInfo { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string WorkVisaCode { get; set; }
        public DateTime? WorkVisaSign { get; set; }
        public DateTime? WorkVisaValid { get; set; }
        public string Country { get; set; }
        public string PassportType { get; set; }
        public string PassportCode { get; set; }
        public string WorkVisaStatus { get; set; }
        public string Remark { get; set; }
        public DateTime? RequestDate { get; set; }
    }
}
