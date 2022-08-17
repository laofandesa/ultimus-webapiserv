using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigSpecialDate
    {
        public int Id { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public DateTime? TargetDate { get; set; }
        public string UseForCode { get; set; }
        public string UseForName { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string GongZiFaFangDi { get; set; }
    }
}
