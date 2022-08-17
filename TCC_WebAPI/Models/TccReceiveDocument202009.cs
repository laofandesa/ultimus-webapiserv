using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccReceiveDocument202009
    {
        public int NewId { get; set; }
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string FormNumber { get; set; }
        public string SenDocCorp { get; set; }
        public string SenDocNo { get; set; }
        public int? EmerLevel { get; set; }
        public string ApplyName { get; set; }
        public string ApplyLoginUser { get; set; }
        public string RecDocNo { get; set; }
        public DateTime? RecDocDate { get; set; }
        public string DocTitle { get; set; }
        public string InfoOpen { get; set; }
        public string ApproveLeader { get; set; }
        public string ApproveLeaderLoginUsers { get; set; }
        public string MainSendDept { get; set; }
        public string MainSendDeptNo { get; set; }
        public DateTime? DeadLine { get; set; }
        public string CopySendDept { get; set; }
        public string CopySendDeptNo { get; set; }
        public string Optionmark { get; set; }
        public string MainSendOption { get; set; }
        public string DealPerson { get; set; }
        public string DealPersonLoginUsers { get; set; }
        public string DocFileId { get; set; }
        public string AttFileId { get; set; }
        public DateTime? SendDocDate { get; set; }
        public int? SecLevel { get; set; }
        public string CopySendDeptLeader { get; set; }
        public int? YbleaderNum { get; set; }
        public int? MainDeptNum { get; set; }
        public string MainSendDeptLeader { get; set; }
        public string IsReport { get; set; }
        public string MainSendDealPerson { get; set; }
        public string MainSendDealPersonLoginUser { get; set; }
        public string Sendzdfz { get; set; }
        public string SendzdfzNo { get; set; }
        public int? HasOpinion { get; set; }
        public int? AttDocType { get; set; }
        public string AttAsdocId { get; set; }
    }
}
