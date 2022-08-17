using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccMailPostChangedReport
    {
        public int Id { get; set; }
        public string ApplyType { get; set; }
        public string JsYm { get; set; }
        public string MailType { get; set; }
        public string Dept { get; set; }
        public string Manager { get; set; }
        public string Totalcost { get; set; }
        public string Changedcost { get; set; }
        public string CostBelongId { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
    }
}
