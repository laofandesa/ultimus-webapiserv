using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccFinancingOfAsset
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string PclassName { get; set; }
        public string ClassName { get; set; }
        public string AssetName { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public decimal? AssetValue { get; set; }
        public decimal? BookValue { get; set; }
        public string DisposalReasons { get; set; }
        public int? DisposalMethod { get; set; }
        public decimal? Disposallosses { get; set; }
        public int? Quantity { get; set; }
        public string DisposalMethodText { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string Spec { get; set; }
        public string Instruction { get; set; }
    }
}
