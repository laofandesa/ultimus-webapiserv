using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPriceLibraryConfig
    {
        public string ParentId { get; set; }
        public string ParProductCode { get; set; }
        public string ProductCode { get; set; }
        public string ProductType { get; set; }
        public string ProductTitle { get; set; }
        public string ProductUnit { get; set; }
        public string Remark { get; set; }
    }
}
