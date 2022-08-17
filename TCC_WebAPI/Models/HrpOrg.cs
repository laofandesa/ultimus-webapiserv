using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class HrpOrg
    {
        public string Codesetid { get; set; }
        public string Codeitemid { get; set; }
        public string Codeitemdesc { get; set; }
        public string Parentid { get; set; }
        public string Childid { get; set; }
        public string State { get; set; }
        public int? Grade { get; set; }
        public int? A0000 { get; set; }
        public int? GroupId { get; set; }
        public string PosCond { get; set; }
        public int? Invalid { get; set; }
        public int? Flag { get; set; }
        public int? Layer { get; set; }
        public string Corcode { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
