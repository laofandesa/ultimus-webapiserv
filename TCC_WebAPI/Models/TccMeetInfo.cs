using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccMeetInfo
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string MeetCostType { get; set; }
        public string FormNumber { get; set; }
        public DateTime? RequestDate { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyTelephone { get; set; }
        public string ApplyMobile { get; set; }
        public string ApplyEmail { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public string OrganizerName { get; set; }
        public string OrganizerKey { get; set; }
        public string OrganizerCardNo { get; set; }
        public int? ApplyType { get; set; }
        public int? MeetType { get; set; }
        public int? MeetForm { get; set; }
        public string VideoObject { get; set; }
        public string CardNo { get; set; }
        public string MeetTitle { get; set; }
        public string MeetContent { get; set; }
        public decimal? MeetBudget { get; set; }
        public string ProjectNo { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManagerName { get; set; }
        public string ProjectManagerLoginName { get; set; }
        public string UseDept { get; set; }
        public string UseDeptId { get; set; }
        public string DeptManagerName { get; set; }
        public string DeptManagerLoginName { get; set; }
        public DateTime? MeetStartDate { get; set; }
        public DateTime? MeetEndDate { get; set; }
        public int? UserNumber { get; set; }
        public string MeetAddress { get; set; }
        public string MeetRemark { get; set; }
        public int? Delay { get; set; }
    }
}
