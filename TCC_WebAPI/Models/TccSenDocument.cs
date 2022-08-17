using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSenDocument
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string SendDocNo { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public int? EmerLevel { get; set; }
        public int? SecLevel { get; set; }
        public string Sendmark { get; set; }
        public string Optionmark { get; set; }
        public string DocTitle { get; set; }
        public int? DocNum { get; set; }
        public string Exammark { get; set; }
        public string DocType { get; set; }
        public string SendType { get; set; }
        public string MainSendDept { get; set; }
        public string CopySendDept { get; set; }
        public string InfoOpen { get; set; }
        public int? IsOption { get; set; }
        public string IsExam { get; set; }
        public string SubDeptNo { get; set; }
        public int? SubDeptNum { get; set; }
        public string MainSendDeptNo { get; set; }
        public string CopySendDeptNo { get; set; }
        public string DocFileId { get; set; }
        public string AttFileId { get; set; }
        public string FormNumber { get; set; }
        public int? SendPlace { get; set; }
        public string SendUnit { get; set; }
        public string SendUnitId { get; set; }
        public string QianfaPerson { get; set; }
        public string QianfaPersonId { get; set; }
        public string QianfaContent { get; set; }
        public DateTime? QianfaTime { get; set; }
        public string HegaoPerson { get; set; }
        public string HegaoPersonId { get; set; }
        public string HegaoContent { get; set; }
        public DateTime? HegaoTime { get; set; }
        public string DocRarFileId { get; set; }
        public string XmlToYonyou { get; set; }
        public string OptionDept { get; set; }
        public DateTime? SendDocDate { get; set; }
        public string Oaid { get; set; }
        public string SendToLeaderId { get; set; }
        public string CoptyToLeaderId { get; set; }
        public string SendKind { get; set; }
        public int? SendNo { get; set; }
        public string RealMainSendDept { get; set; }
        public string SendFw { get; set; }
        public string Sendzdfz { get; set; }
        public string SendzdfzNo { get; set; }
        public int? IsQianfa { get; set; }
        public int? PaperNum { get; set; }
    }
}
