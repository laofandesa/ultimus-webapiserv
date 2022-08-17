using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAbroadWorkVisaUserTempt
    {
        public int Id { get; set; }
        public string CompName { get; set; }
        public string Pinyin { get; set; }
        public string Name { get; set; }
        public string UserKey { get; set; }
        public string JobTitle { get; set; }
        public string ProjectInfo { get; set; }
        public string WorkVisaCode { get; set; }
        public DateTime? WorkVisaSign { get; set; }
        public DateTime? WorkVisaValid { get; set; }
        public string Country { get; set; }
        public string WorkVisaStatus { get; set; }
        public string Remark { get; set; }
    }
}
