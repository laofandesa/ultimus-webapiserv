using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBasicAuthorityRelation20181122
    {
        public int Id { get; set; }
        public string PageName { get; set; }
        public int? Authority { get; set; }
        public string Account { get; set; }
        public string DeptCode { get; set; }
        public int? Flag { get; set; }
        public DateTime? EditDate { get; set; }
        public string EditLogin { get; set; }
    }
}
