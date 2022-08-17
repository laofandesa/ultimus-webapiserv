using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewHousingsubsidyInfo
    {
        public string Name { get; set; }
        public string Useridentity { get; set; }
        public string SalaryLocation { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string EducationLevel { get; set; }
        public string PayCategory { get; set; }
        public int Category { get; set; }
    }
}
