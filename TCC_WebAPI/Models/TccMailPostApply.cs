using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccMailPostApply
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
        public string ProjectNo { get; set; }
        public string ProjectName { get; set; }
        public string FormNumber { get; set; }
        public string ServiceStatus { get; set; }
        public string ProjectManagerName { get; set; }
        public string RealDoneTime { get; set; }
        public string ProjectApprovalRealName { get; set; }
        public string ProjectApprovalLoginName { get; set; }
        public string ServiceContent { get; set; }
        public string DeptManagerName { get; set; }
        public string TotalCost { get; set; }
        public string MailType { get; set; }
        public string MailPlace { get; set; }
        public string MailThingsNum { get; set; }
        public string RecMailPerson { get; set; }
        public string MsgSendCts { get; set; }
        public string MsgSendTime { get; set; }
    }
}
