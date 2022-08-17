using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAccountRelation
    {
        public int Id { get; set; }
        public string SupplierCode { get; set; }
        public string AccountName { get; set; }
        public string AccountCode { get; set; }
    }
}
