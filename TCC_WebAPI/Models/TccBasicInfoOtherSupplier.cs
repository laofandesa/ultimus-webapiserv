using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBasicInfoOtherSupplier
    {
        public int Id { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string Khh { get; set; }
        public string Khhzh { get; set; }
        public string Khhdz { get; set; }
        public string Lhhh { get; set; }
        public string SwiftCode { get; set; }
        public string LbanCode { get; set; }
        public string AbaCode { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? IsDelete { get; set; }
        public string InvoicesUnitName { get; set; }
        public int? Source { get; set; }
        public string RegisterArea { get; set; }
    }
}
