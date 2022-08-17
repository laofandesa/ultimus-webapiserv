using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTheForthAwardRecordPackage
    {
        public int Id { get; set; }
        public string UserIdentityId { get; set; }
        public int? Year { get; set; }
        public string NewSalaryVest { get; set; }
        public int? PackageNo { get; set; }
        public decimal? Money { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
