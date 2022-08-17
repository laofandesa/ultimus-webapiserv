using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewPeptjProjectInfo
    {
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
        public double AllowanceAmount { get; set; }
        public int? IsByAir { get; set; }
        public string ProjTypeDesc { get; set; }
        public string ProjSubTypeDesc { get; set; }
        public DateTime? BuildDate { get; set; }
        public string RunningMode { get; set; }
        public string Xmgs { get; set; }
        public bool? IsCost { get; set; }
        public string ProjStatus { get; set; }
        public int Qqflag { get; set; }
        public int Qqlevel { get; set; }
        public int Accounttype { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    }
}
