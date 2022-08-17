using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewPeptjSupplyInfo
    {
        public Guid Sid { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string RegisterArea { get; set; }
        public string CompanyAddress { get; set; }
        public string BankName { get; set; }
        public string BankNumber { get; set; }
        public string BankAddress { get; set; }
        public string BankLinkNumber { get; set; }
        public string Swiftcode { get; set; }
        public string Ibancode { get; set; }
        public string Abacode { get; set; }
        public bool HasContract { get; set; }
        public bool? HasLegaldispute { get; set; }
        public DateTime? Registerdate { get; set; }
        public DateTime? Addorupdatedate { get; set; }
    }
}
