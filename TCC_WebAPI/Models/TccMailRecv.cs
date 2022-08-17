using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccMailRecv
    {
        public int Id { get; set; }
        public DateTime? MailRecvDate { get; set; }
        public string MailType { get; set; }
        public string MailNo { get; set; }
        public string MailPlace { get; set; }
        public string RecvName { get; set; }
        public string CostDept { get; set; }
        public DateTime? MsgSendTime { get; set; }
        public int? MsgSendCts { get; set; }
        public string GetMailPerson { get; set; }
        public DateTime? GetMailDate { get; set; }
        public string RecvLoginName { get; set; }
        public string GetPersonLoginName { get; set; }
        public string RecordStatus { get; set; }
    }
}
