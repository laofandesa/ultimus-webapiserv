using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPrintApply
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyPhone { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public string CostDeptNo { get; set; }
        public string CostDept { get; set; }
        public string ApplyType { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string ServiceType { get; set; }
        public string ServiceMxType { get; set; }
        public string ProjectNo { get; set; }
        public string ProjectName { get; set; }
        public string FormNumber { get; set; }
        public string ServiceStatus { get; set; }
        public string ProjectManagerName { get; set; }
        public string WorkFloorNo { get; set; }
        public string ServiceContent { get; set; }
        public string Remarks { get; set; }
        public string Gjcost { get; set; }
        public string WorkUserName { get; set; }
        public string WorkLoginUser { get; set; }
        public string MsgSendCts { get; set; }
        public string MsgSendTime { get; set; }
        public string CostBelong { get; set; }
        public string Discount { get; set; }
        public string Realcost { get; set; }
        public string ChangcostBeizhu { get; set; }
        public string ServiceFloor { get; set; }
        public string CountCostLoginUser { get; set; }
        public string WorkedUserNames { get; set; }
        public string WorkedLoginUsers { get; set; }
        public string RecieveUser { get; set; }
        public string RecieveTime { get; set; }
        public string DealLineTime { get; set; }
        public string RealDoneTime { get; set; }
        public string RealZdDgzs { get; set; }
        public string Countcost { get; set; }
        public string SavedUserNames { get; set; }
        public string SavedLoginUsers { get; set; }
        public string ProjectApprovalRealName { get; set; }
        public string ProjectApprovalLoginName { get; set; }
        public string SpfformNumber { get; set; }
        public string ProjectSecAndPhone { get; set; }
    }
}
