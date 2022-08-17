using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPriceLibraryInfoSub
    {
        public int Id { get; set; }
        public string FormNumber { get; set; }
        public string ApplyLogin { get; set; }
        public string ProductCode { get; set; }
        public string ProductTitle { get; set; }
        public string ProductName { get; set; }
        public double? ProductPrePrice { get; set; }
        public double? ProductPrice { get; set; }
        public DateTime? PubDate { get; set; }
        public string ProcuctVersion { get; set; }
    }
}
