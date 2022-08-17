using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccEmployeeStartTask
    {
        public int Id { get; set; }
        public string FormNumber { get; set; }
        public string DeptName { get; set; }
        public string MainNo { get; set; }
        public string DeptNo { get; set; }
        public string Name { get; set; }
        public string NameKey { get; set; }
        public string HrpId { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string DeptLeader { get; set; }
        public string DeptLeaderKey { get; set; }
        public string CheckStatus { get; set; }
        public string CheckId { get; set; }
        public DateTime? RequstDate { get; set; }
        public int? Flag { get; set; }
        public int? EmployeeType { get; set; }
        public int? UserType { get; set; }
        public double? CheckScore { get; set; }
        public string CheckDegree { get; set; }
        public string CheckRemark { get; set; }
        public string CheckDecision { get; set; }
        public string CheckDeptScore { get; set; }
        public string CheckDecisionInfo { get; set; }
        public string CheckSugest { get; set; }
        public string IsAgree { get; set; }
        public string AgreeInfo { get; set; }
        public string Approve { get; set; }
        public string ApproveInfo { get; set; }
        public int? IsDelete { get; set; }
    }
}
