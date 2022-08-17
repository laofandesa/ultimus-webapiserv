using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewFinancePayProcessing
    {
        public int ID { get; set; }
        public string Xmbh { get; set; }
        public string Htbh { get; set; }
        public string ContType { get; set; }
        public DateTime? Fksj { get; set; }
        public int? Dzsj { get; set; }
        public string Fkjd { get; set; }
        public decimal? Fkje { get; set; }
        public string Bz { get; set; }
        public decimal? Rmb { get; set; }
        public string Jbr { get; set; }
        public int? Czr { get; set; }
        public int? Htlx { get; set; }
        public string Htlxname { get; set; }
        public int? RequestPayCategory { get; set; }
        public string RequestPayCategoryName { get; set; }
        public int? PaymentNode { get; set; }
        public string PaymentNodeName { get; set; }
    }
}
