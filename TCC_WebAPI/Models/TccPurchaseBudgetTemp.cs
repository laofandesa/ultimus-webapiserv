using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPurchaseBudgetTemp
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string GclassName { get; set; }
        public string GclassCode { get; set; }
        public string PclassName { get; set; }
        public string PclassCode { get; set; }
        public string CclassName { get; set; }
        public string CclassCode { get; set; }
        public string AssetName { get; set; }
        public int? UnitCode { get; set; }
        public string Unit { get; set; }
        public decimal? Number { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Amount { get; set; }
        public string Remark { get; set; }
        public string ManageDept { get; set; }
        public string ManageDeptName { get; set; }
        public string UseDept { get; set; }
        public string AttFileName { get; set; }
        public int? AttUserId { get; set; }
        public string AttUserName { get; set; }
        public DateTime? AttCreateDate { get; set; }
        public int? AttFileId { get; set; }
        public int? AttState { get; set; }
        public decimal? NumberAct { get; set; }
    }
}
