using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDrawingArchiveApply
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyPhone { get; set; }
        public string ApplyDate { get; set; }
        public string ProjectNo { get; set; }
        public string ProjectName { get; set; }
        public string FormNumber { get; set; }
        public string ApplyMajor { get; set; }
        public string ApplyMajorNo { get; set; }
        public string ArchiveType { get; set; }
        public string DesignStage { get; set; }
        public string WorkArea { get; set; }
        public string WorkAreaId { get; set; }
        public string MutiArchiveMajor { get; set; }
        public string MutiArchiveMajorId { get; set; }
        public string MutiArchiveMajorCode { get; set; }
        public string ArchiveMajor { get; set; }
        public string ArchiveMajorId { get; set; }
        public string MutiWorkArea { get; set; }
        public string MutiWorkAreaId { get; set; }
        public string MutiWorkAreaCode { get; set; }
        public string IsPressure { get; set; }
        public string Seal { get; set; }
        public string SendDraw { get; set; }
        public string SendDrawCount { get; set; }
        public string PackType { get; set; }
        public string PackCount { get; set; }
        public string PressureApprovalRealName { get; set; }
        public string PressureApprovalLoginName { get; set; }
        public int? MajorLeaderNum { get; set; }
        public int? SubmitMajorLeaderNum { get; set; }
        public int? PressureApprovalPersonNum { get; set; }
        public int? SubmitPressureApprovalPersonNum { get; set; }
        public int? HasPp { get; set; }
        public int? HasPc { get; set; }
        public int? MsgSendCtsDt { get; set; }
        public string MsgSendTimeDt { get; set; }
        public int? MsgSendCtsWyc { get; set; }
        public string MsgSendTimeWyc { get; set; }
        public string HasWorkArea { get; set; }
        public string UnArchiveMajors { get; set; }
        public string UnArchiveMajorIds { get; set; }
        public string OnlyPressureSeal { get; set; }
        public string UnSeal { get; set; }
        public string SealUse { get; set; }
        public string ArchiveByProjectMajors { get; set; }
        public string ArchiveByProjectMajorsIds { get; set; }
        public string UnSealReasonWyc { get; set; }
        public string UnSealReasonJsb { get; set; }
        public int? MsgSendCtsJsb { get; set; }
        public string MsgSendTimeJsb { get; set; }
        public string ReceiveCompany { get; set; }
        public string MutiArchiveMajorDeptId { get; set; }
        public string ArchiveMajorDeptId { get; set; }
        public string UnArchiveMajorDeptIds { get; set; }
        public string ArchiveByProjectMajorsDeptIds { get; set; }
        public string ArchiveMajorCode { get; set; }
        public string PrintFormNumber { get; set; }
        public string PrintForSeal { get; set; }
        public string BgNum { get; set; }
        public string JssNum { get; set; }
        public string WzNum { get; set; }
    }
}
