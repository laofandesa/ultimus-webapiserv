using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSurveyRisk
    {
        public int Id { get; set; }
        public int? RequestYear { get; set; }
        public string RequestQuarter { get; set; }
        public DateTime? RequestDate { get; set; }
        public string DeptNo { get; set; }
        public string DeptName { get; set; }
        public string ProjectCode { get; set; }
        public int? SurveyType { get; set; }
        public string SurveyCode { get; set; }
        public string UserKey { get; set; }
        public string UserName { get; set; }
        public string Possibility { get; set; }
        public string Efficiency { get; set; }
        public string Emergency { get; set; }
        public string EventDesc { get; set; }
    }
}
