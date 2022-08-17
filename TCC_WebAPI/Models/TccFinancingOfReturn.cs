using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccFinancingOfReturn
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public int? Category { get; set; }
        public string FinancingItemName { get; set; }
        public decimal? CurReFinancingAmount { get; set; }
        public DateTime? PcapitalReturnDate { get; set; }
        public string ProvideFunds { get; set; }
        public decimal? BorrowingRate { get; set; }
        public decimal? InterestExpense { get; set; }
        public string Remark { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
    }
}
