using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewProjectInfo
    {
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Xmjl { get; set; }
        public string Isfinish { get; set; }
        public string ProjectCategory { get; set; }
        public string ProjectType { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double CheckValue { get; set; }
        public decimal ContMoney { get; set; }
        public double PayMoney { get; set; }
        public decimal RamountCny { get; set; }
        public double RperCny { get; set; }
        public decimal PaymentAmount { get; set; }
        public double? Pper { get; set; }
        public double? PayablePaymentAmount { get; set; }
        public decimal? ManagementCost { get; set; }
        public string ProjTypeDesc { get; set; }
    }
}
