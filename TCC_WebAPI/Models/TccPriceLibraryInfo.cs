using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPriceLibraryInfo
    {
        public int Id { get; set; }
        public string ProductType { get; set; }
        public string ProductCode { get; set; }
        public string ProductTitle { get; set; }
        public string ProductUnit { get; set; }
        public double? ProductPrice { get; set; }
        public DateTime? PubDate { get; set; }
        public string RemarkInfo { get; set; }
        public string ProcuctVersion { get; set; }
    }
}
