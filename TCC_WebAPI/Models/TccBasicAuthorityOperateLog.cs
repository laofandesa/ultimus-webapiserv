using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBasicAuthorityOperateLog
    {
        public int Id { get; set; }
        public string PageName { get; set; }
        public int? Authority { get; set; }
        public string Account { get; set; }
        public int? Flag { get; set; }
        public DateTime? OpreateDate { get; set; }
        public string OpeateLogin { get; set; }
        public int? OpreateType { get; set; }
    }
}
