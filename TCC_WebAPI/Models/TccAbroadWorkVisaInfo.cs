using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAbroadWorkVisaInfo
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public string FormNumber { get; set; }
        public string ApplyLogin { get; set; }
        public string CompName { get; set; }
        public string DeptNo { get; set; }
        public string DeptName { get; set; }
        public string Name { get; set; }
        public DateTime? BornDate { get; set; }
        public int? Sex { get; set; }
        public string UserKey { get; set; }
        public string Tvcountry { get; set; }
        public string PassportType { get; set; }
        public string PassportCode { get; set; }
        public string JobTitle { get; set; }
        public string Countersign { get; set; }
    }
}
