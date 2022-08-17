using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class AbroadVisaValid
    {
        public int Id { get; set; }
        public string FormNumber { get; set; }
        public string Name { get; set; }
        public string UserKey { get; set; }
        public string PassportCode { get; set; }
        public string VisaCountry { get; set; }
        public DateTime? VisaSign { get; set; }
        public string VisaType { get; set; }
        public string VisaCode { get; set; }
        public DateTime VisaValid { get; set; }
        public int? VisaDays { get; set; }
        public string VisaNum { get; set; }
        public string VisaStatus { get; set; }
    }
}
