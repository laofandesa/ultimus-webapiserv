using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class AwardMoneyDispenseHistory
    {
        public int Id { get; set; }
        public string UserIdentityId { get; set; }
        public string UserName { get; set; }
        public int Year { get; set; }
        public int Qt { get; set; }
        public int? MonthInPool { get; set; }
        public decimal AwardMoney { get; set; }
        public int DispenseYear { get; set; }
        public int DispenseQt { get; set; }
        public int DispenseMonth { get; set; }
        public decimal DispenseMoney { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDel { get; set; }
        public bool IsLeave { get; set; }
    }
}
