using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccManagementAward
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string AwardCategory { get; set; }
        public string FormNumber { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyId { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public string DeptMangerId { get; set; }
        public string DeptMangerlogin { get; set; }
        public string DeptMangerDeptNo { get; set; }
        public string DeptMangerDeptName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string TotalReleasedAmount { get; set; }
        public string TotalBobusBudgetYear { get; set; }
        public string ResidualAmount { get; set; }
        public string CanAssign { get; set; }
        public string InlandAssignStatus { get; set; }
        public string AbroadAssignStatus { get; set; }
        public string AbroadAssignStatus2 { get; set; }
        public string Flag { get; set; }
        public DateTime? ReciverDate { get; set; }
        public string InlandAuditStatus { get; set; }
        public string AbroadAuditStatus { get; set; }
        public string AbroadAuditStatus2 { get; set; }
        public string InlandAuditStatusJy { get; set; }
        public string AbroadAuditStatusJy { get; set; }
        public string AbroadAuditStatus2Jy { get; set; }
        public string InlandAuditStatusFjy { get; set; }
        public string AbroadAuditStatusFjy { get; set; }
        public string AbroadAuditStatus2Fjy { get; set; }
        public string StatusGnjy { get; set; }
        public string StatusHwjy { get; set; }
        public string Status2Hwjy { get; set; }
        public string StatusFjy { get; set; }
        public DateTime? ProcessFinshDate { get; set; }
        public string MarkingFjy { get; set; }
    }
}
