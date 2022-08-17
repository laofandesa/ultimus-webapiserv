using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectSpecialAmountInit
    {
        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectManagerIdentity { get; set; }
        public string ProjTypeDesc { get; set; }
        public decimal? SpecAllowance { get; set; }
        public int? Flag { get; set; }
    }
}
