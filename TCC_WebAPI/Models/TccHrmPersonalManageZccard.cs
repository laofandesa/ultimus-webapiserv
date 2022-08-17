using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmPersonalManageZccard
    {
        public int Id { get; set; }
        public int PmFk { get; set; }
        public string JobTitle { get; set; }
        public string JobTitleId { get; set; }
        public string JobTitleUpdateDate { get; set; }
        public string HasZyzg { get; set; }
        public string HasZyzgid { get; set; }
        public string SendPlace { get; set; }
        public string TitleType { get; set; }
        public string TitleTypeId { get; set; }
        public string TitleNo { get; set; }
        public string TitleApprovelDoc { get; set; }
        public string TitleRemark { get; set; }
        public string TitleMajor { get; set; }
        public string TitleSend { get; set; }
        public string TitleSendId { get; set; }
        public string TitleSendDate { get; set; }
    }
}
