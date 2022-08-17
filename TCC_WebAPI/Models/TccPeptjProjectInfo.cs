using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPeptjProjectInfo
    {
        public int Id { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Xmjl { get; set; }
        public string Isfinish { get; set; }
        public string ProjectCategory { get; set; }
        public string ContractType { get; set; }
        public string ProjectType { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? Finishdate { get; set; }
        public string Jnw { get; set; }
        public decimal? AllowanceAmount { get; set; }
        public int? IsByAir { get; set; }
        public string ProjTypeDesc { get; set; }
        public string ProjSubTypeDesc { get; set; }
        public DateTime? BuildDate { get; set; }
        public string RunningMode { get; set; }
        public string Xmgs { get; set; }
        public int? IsCost { get; set; }
        public string ProjStatus { get; set; }
        public string ProjTypeDescLocation { get; set; }
        public string ProjSubTypeDescLocation { get; set; }
        public int? Accounttype { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    }
}
