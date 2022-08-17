using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccMailPostApplyMx
    {
        public string FormNumber { get; set; }
        public int Id { get; set; }
        public string MailType { get; set; }
        public string MailDest { get; set; }
        public string MailThings { get; set; }
        public string MailNo { get; set; }
        public string RecMailPerson { get; set; }
        public string MailCost { get; set; }
        public string Remark { get; set; }
        public string MailThingsKind { get; set; }
        public string MailThingsNum { get; set; }
        public string MailStatus { get; set; }
        public string RealDoneTime { get; set; }
        public string GiveMailPerson { get; set; }
        public string GiveMailTime { get; set; }
    }
}
