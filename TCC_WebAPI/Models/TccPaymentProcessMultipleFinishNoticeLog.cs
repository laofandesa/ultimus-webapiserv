using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessMultipleFinishNoticeLog
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string LoginName { get; set; }
        public string Msg { get; set; }
        public DateTime? SendTime { get; set; }
        public string Emaill { get; set; }
    }
}
