using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSuggestSurveyValue
    {
        public int Id { get; set; }
        public string SurveyDept { get; set; }
        public string SurveyPossition { get; set; }
        public string SurveyUserType { get; set; }
        public int? SurveyId { get; set; }
        public string SurveyTitle { get; set; }
        public string SugestValue { get; set; }
        public DateTime? RequestDate { get; set; }
        public string SId { get; set; }
    }
}
