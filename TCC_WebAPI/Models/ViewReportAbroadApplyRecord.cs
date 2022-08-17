using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportAbroadApplyRecord
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string AbroadTypeInfo { get; set; }
        public int? ProcessStatus { get; set; }
        public string FormNumber { get; set; }
        public DateTime? RequestDate { get; set; }
        public string AgentName { get; set; }
        public string AgentLoginUser { get; set; }
        public string AgentDeptName { get; set; }
        public int? Agency { get; set; }
        public string RequestRealName { get; set; }
        public string RequestUserName { get; set; }
        public string RequestDeptNo { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestTelephone { get; set; }
        public int? AbroadType { get; set; }
        public int? FlgType { get; set; }
        public string AbroadSpecTypeInfo { get; set; }
        public string PartnerName { get; set; }
        public string ContractType { get; set; }
        public string ContractScope { get; set; }
        public string ContractLimit { get; set; }
        public string AbrodDeptNo { get; set; }
        public string AbrodDeptName { get; set; }
        public string Projector { get; set; }
        public string ProjectorId { get; set; }
        public string ProjectNo { get; set; }
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public string ProjectGm { get; set; }
        public string ProjectPosition { get; set; }
        public string ProjectJd { get; set; }
        public string ProjectJdinfo { get; set; }
        public string ProjectOwner { get; set; }
        public string OrganizeName { get; set; }
        public string InviteCname { get; set; }
        public string InviteEname { get; set; }
        public string TaskType { get; set; }
        public string DealType { get; set; }
        public string CoseSouce { get; set; }
        public string PayComName { get; set; }
        public string AttendInfo { get; set; }
        public string ApplyReason { get; set; }
        public string SpecialReason { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Tvcountry { get; set; }
        public string RoadInfo { get; set; }
        public string VisaType { get; set; }
        public string VisaTypeNo { get; set; }
        public string VisaOther { get; set; }
        public string VisaNum { get; set; }
        public string PassportType { get; set; }
        public string PassportTypeNo { get; set; }
        public string PassportReason { get; set; }
        public string VisaSec { get; set; }
        public string VisaSecInfo { get; set; }
        public DateTime? ReturnPaperDate { get; set; }
        public DateTime? BorrowDate { get; set; }
        public int? AssignNum { get; set; }
        public int? VisitDays { get; set; }
        public string Embassy { get; set; }
        public string VisaCity { get; set; }
        public string OverReason { get; set; }
        public string TeamLeader { get; set; }
        public string FlowStatus { get; set; }
        public int? DepAgreeNum { get; set; }
    }
}
