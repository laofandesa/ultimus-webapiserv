using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewFinanceReceiveofTaxHistory
    {
        public int Id { get; set; }
        public string Xmbh { get; set; }
        public string Htbh { get; set; }
        public string ContType { get; set; }
        public DateTime? Sksj { get; set; }
        public DateTime? Dzsj { get; set; }
        public string Skjd { get; set; }
        public decimal? Skje { get; set; }
        public string Bz { get; set; }
        public decimal? Rmb { get; set; }
        public string Jbr { get; set; }
        public string Czr { get; set; }
        public int? RequestPayCategory { get; set; }
        public string RequestPayCategoryName { get; set; }
        public int? RequestNode { get; set; }
        public string RequestNodeName { get; set; }
    }
}
