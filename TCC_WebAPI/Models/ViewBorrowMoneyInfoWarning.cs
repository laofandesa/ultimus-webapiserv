using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBorrowMoneyInfoWarning
    {
        public int? DraftType { get; set; }
        public int? StatusName { get; set; }
        public int SendType { get; set; }
        public string DueDateStr { get; set; }
        public DateTime? DueDate { get; set; }
        public int? DraftCode { get; set; }
        public decimal? Damount { get; set; }
        public string Currency { get; set; }
        public int? Cts { get; set; }
        public string LoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestUserIdentity { get; set; }
    }
}
