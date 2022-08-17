using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigSurveyRisk
    {
        public string SurveyParentCode { get; set; }
        public string SurveyCode { get; set; }
        public int? SurveyType { get; set; }
        public string SurveyTitle { get; set; }
        public string SurveyDesc { get; set; }
        public int SurveyOrder { get; set; }
        public int? SurveyRoot { get; set; }
    }
}
