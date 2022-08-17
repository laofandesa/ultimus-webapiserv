using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigRiskEstimate
    {
        public int Id { get; set; }
        public string ParentCode { get; set; }
        public string SurveyCode { get; set; }
        public int? SurveyType { get; set; }
        public string FirstType { get; set; }
        public string FirstNo { get; set; }
        public string FirstCode { get; set; }
        public string SecType { get; set; }
        public string SecNo { get; set; }
        public string SecCode { get; set; }
        public string ThirdType { get; set; }
        public string ThirdNo { get; set; }
        public string ThirdCode { get; set; }
        public string InfoDesc { get; set; }
        public string Possibility { get; set; }
        public string Efficiency { get; set; }
        public string Emergency { get; set; }
        public string EventDesc { get; set; }
        public int? OrderNo { get; set; }
    }
}
