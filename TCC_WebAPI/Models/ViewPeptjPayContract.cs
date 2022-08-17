using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewPeptjPayContract
    {
        public string ProjId { get; set; }
        public string ContType { get; set; }
        public string ContCate { get; set; }
        public string Htbh { get; set; }
        public string Htmc { get; set; }
        public string Htxs { get; set; }
        public string Bz { get; set; }
        public decimal? Hthl { get; set; }
        public double? Htqyje { get; set; }
        public double? HtqyjeOc { get; set; }
        public double? Bgje { get; set; }
        public double? BgjeOc { get; set; }
        public double? Htze { get; set; }
        public double? HtzeOc { get; set; }
        public string Skdwmc { get; set; }
        public string Kpdwmc { get; set; }
        public string Skdwdz { get; set; }
        public string Khh { get; set; }
        public string Khhzh { get; set; }
        public string Lhhh { get; set; }
        public string Myfs { get; set; }
        public string Khhzi { get; set; }
        public string Swiftcode { get; set; }
        public string Lbancode { get; set; }
        public string Abacode { get; set; }
        public string Ysfs { get; set; }
        public string Skdwbh { get; set; }
        public int? IsBh { get; set; }
        public string PartAName { get; set; }
        public string PartAId { get; set; }
        public string JbrIdent { get; set; }
        public string JbrName { get; set; }
        public string UnitJnw { get; set; }
        public string ProjName { get; set; }
        public string PartBName { get; set; }
        public string PartBId { get; set; }
        public string SignHuman { get; set; }
        public DateTime? SignDate { get; set; }
        public string ContSid { get; set; }
        public int? ContType1 { get; set; }
        public string DeptId { get; set; }
        public string DdZt { get; set; }
        public int? IncludeTax { get; set; }
        public decimal? Tax { get; set; }
        public int? BNotInit { get; set; }
        public string Cgfkfs { get; set; }
        public string PmName { get; set; }
        public string ContractLawsuit { get; set; }
        public int? DSid { get; set; }
        public Guid? Sid { get; set; }
        public decimal? Money { get; set; }
    }
}
