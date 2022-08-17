using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmPersonalManageZffcard
    {
        public int Id { get; set; }
        public int PmFk { get; set; }
        public string SendChangeDate { get; set; }
        public string SendEndDate { get; set; }
        public string MonthStandard { get; set; }
    }
}
