using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigSurveySuggest
    {
        public int Id { get; set; }
        public string SurveyTitle { get; set; }
        public string Dimension { get; set; }
        public string Related { get; set; }
        public int? SurveyTypeId { get; set; }
    }
}
