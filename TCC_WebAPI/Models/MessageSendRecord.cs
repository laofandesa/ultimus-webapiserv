using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class MessageSendRecord
    {
        public int MsrId { get; set; }
        public string MsrProcessName { get; set; }
        public int? MsrIncidentNo { get; set; }
        public string MsrStepName { get; set; }
        public string MsrFromUser { get; set; }
        public string MsrToUser { get; set; }
        public int? MsrType { get; set; }
        public string MsrTarget { get; set; }
        public DateTime? MsrSendTime { get; set; }
        public string MsrTitle { get; set; }
        public string MsrContent { get; set; }
        public string MstCode { get; set; }
        public int? MsrResult { get; set; }
        public string MsrResultDesc { get; set; }
    }
}
