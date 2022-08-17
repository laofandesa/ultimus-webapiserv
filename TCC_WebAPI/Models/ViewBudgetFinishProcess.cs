using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBudgetFinishProcess
    {
        public int Id { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestSfzh { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestFormNumber { get; set; }
        public int? BdgType { get; set; }
        public int? LevelFlag { get; set; }
        public string Year { get; set; }
        public string BatchNumber { get; set; }
        public string BdgTitle { get; set; }
    }
}
