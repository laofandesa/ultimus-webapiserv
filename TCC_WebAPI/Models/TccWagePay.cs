using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccWagePay
    {
        public int Id { get; set; }
        public int? Type { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal? Coefficient1 { get; set; }
        public decimal? Coefficient2 { get; set; }
        public decimal? Coefficient3 { get; set; }
        public decimal? Coefficient4 { get; set; }
        public decimal? Coefficient5 { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
