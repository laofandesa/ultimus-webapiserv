using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class MessageSend
    {
        public int MsId { get; set; }
        public string MsProcessName { get; set; }
        public int? MsIncidentNo { get; set; }
        public string MsStepName { get; set; }
        public string MsFrom { get; set; }
        public string MsTo { get; set; }
        public DateTime? MsCreateTime { get; set; }
        public int? MsIsSendMail { get; set; }
        public int? MsIsSendMobile { get; set; }
        public int? MsIsSendOther { get; set; }
        public int? MsIsReadNotice { get; set; }
        public string MsTitle { get; set; }
        public string MsContent { get; set; }
        public string MstCode { get; set; }
        public string MsOpenUrl { get; set; }
        public string MsThirdpartyId { get; set; }
    }
}
