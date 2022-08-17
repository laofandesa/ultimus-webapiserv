using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccApplyForLeave
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string FormNumber { get; set; }
        public int? Agency { get; set; }
        public string AgentName { get; set; }
        public string AgentDeptName { get; set; }
        public string AgentLoginUser { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyUserKey { get; set; }
        public string ApplyName { get; set; }
        public string ApplyPhone { get; set; }
        public DateTime? RequestDate { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyDeptNo { get; set; }
        public string Position { get; set; }
        public string CardNo { get; set; }
        public int? Sex { get; set; }
        public int? Age { get; set; }
        public string CallPeople { get; set; }
        public string CallAdress { get; set; }
        public string FuneralUser { get; set; }
        public int? AlowApply { get; set; }
        public int? UserType { get; set; }
        public DateTime? EnterWorkDate { get; set; }
        public DateTime? WorkDate { get; set; }
        public string WorkPlace { get; set; }
        public string TypeId { get; set; }
        public string TypeName { get; set; }
        public int? PregMonth { get; set; }
        public DateTime? PregnantDate { get; set; }
        public DateTime? AbortionDate { get; set; }
        public int? Brnumber { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string Hjstate { get; set; }
        public int? IsMarry { get; set; }
        public string Jyway { get; set; }
        public DateTime? CbornDate { get; set; }
        public string BornWay { get; set; }
        public string CallAddress { get; set; }
        public int? BornNumber { get; set; }
        public int? BornSec { get; set; }
        public string BrsfirstTime { get; set; }
        public string BrefirstTime { get; set; }
        public string BrssecondTime { get; set; }
        public string BresecondTime { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ActualBeginDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public decimal? RemainDays { get; set; }
        public decimal? VacationDays { get; set; }
        public decimal? AlreadyDays { get; set; }
        public decimal? AvailDays { get; set; }
        public decimal? WorkDays { get; set; }
        public decimal? WorkHours { get; set; }
        public decimal? ApplyHours { get; set; }
        public decimal? ApplyDays { get; set; }
        public decimal? ApplyTime { get; set; }
        public string ApplyReason { get; set; }
        public int? Flag { get; set; }
    }
}
