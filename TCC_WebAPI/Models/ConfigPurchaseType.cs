using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigPurchaseType
    {
        public int Id { get; set; }
        public string CategoryId { get; set; }
        public string Category { get; set; }
        public string ProductType { get; set; }
        public string ProductTypeCode { get; set; }
    }
}
