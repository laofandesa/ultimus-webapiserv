using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewCashierConfirmExportAnnual
    {
        public int Id { get; set; }
        public string Zh { get; set; }
        public string Xm { get; set; }
        public decimal? Je { get; set; }
        public int? Location { get; set; }
    }
}
