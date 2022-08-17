using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAwardAssign2ProjectLine
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLoginName { get; set; }
        public string AwardCategory { get; set; }
        public string ProjectCategory { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManager { get; set; }
        public string UserIdentity { get; set; }
        public string ProjectManagerName { get; set; }
        public decimal? HoursActual { get; set; }
        public decimal? Optimization { get; set; }
        public string OptimalContent { get; set; }
        public decimal? WorkEvaluation { get; set; }
        public decimal? Adjustment { get; set; }
        public decimal? AwardBase { get; set; }
        public decimal? HoursSafe { get; set; }
        public decimal? SafetyAssessment { get; set; }
        public string AccidentsRecord { get; set; }
        public string WorkSubcontractors { get; set; }
        public decimal? DesignSubcontractAmount { get; set; }
        public decimal? DesignSubcontractPayAmount { get; set; }
        public decimal? Amount { get; set; }
        public string CanAssign { get; set; }
        public DateTime? ReceiverDate { get; set; }
        public int? AssignStatus { get; set; }
        public DateTime? AssignDate { get; set; }
        public string Summary { get; set; }
    }
}
