using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewAwardSender
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string AwardCode { get; set; }
        public string SenderLoginName { get; set; }
        public string SenderIdCardNo { get; set; }
        public string SenderRealName { get; set; }
        public string ReceiverIdCardNo { get; set; }
    }
}
