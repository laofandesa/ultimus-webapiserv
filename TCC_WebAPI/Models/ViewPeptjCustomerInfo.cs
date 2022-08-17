using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewPeptjCustomerInfo
    {
        public Guid Sid { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNameEx { get; set; }
        public string Domain { get; set; }
        public string TaxNumber { get; set; }
        public string BankName { get; set; }
        public string BankNumber { get; set; }
        public string BankLinkNumber { get; set; }
        public DateTime? Registerdate { get; set; }
        public DateTime? Addorupdatedate { get; set; }
    }
}
