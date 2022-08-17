using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSurvey
    {
        public int Id { get; set; }
        public int? RequestYear { get; set; }
        public string RequestQuarter { get; set; }
        public DateTime? RequestDate { get; set; }
        public string DeptNo { get; set; }
        public string DeptName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int? SurveyType { get; set; }
        public string UserKey { get; set; }
        public string UserName { get; set; }
    }
}
