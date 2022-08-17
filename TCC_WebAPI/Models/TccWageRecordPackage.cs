using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccWageRecordPackage
    {
        public int Id { get; set; }
        public string UserIdentityId { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public string NewSalaryVest { get; set; }
        public int? PackageNo { get; set; }
        public decimal? Money { get; set; }
    }
}
