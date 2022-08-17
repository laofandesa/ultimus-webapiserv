using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAttachment
    {
        public int AttId { get; set; }
        public string AttProcessName { get; set; }
        public int? AttIncident { get; set; }
        public string AttStepName { get; set; }
        public string AttFileName { get; set; }
        public int? AttUserId { get; set; }
        public string AttUserName { get; set; }
        public DateTime? AttCreateDate { get; set; }
        public int? AttFileId { get; set; }
        public int? AttState { get; set; }
        public string AttGuid { get; set; }
        public int? AttFileUse { get; set; }
        public string AttAsdocId { get; set; }
    }
}
