using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigPurchaseItemBudget
    {
        public int Id { get; set; }
        public string GclassName { get; set; }
        public string GclassCode { get; set; }
        public string PclassName { get; set; }
        public string PclassCode { get; set; }
        public string CclassName { get; set; }
        public string CclassCode { get; set; }
        public string DeptCode { get; set; }
        public string ItemCode { get; set; }
        public string Item2 { get; set; }
        public string ItemSubCode { get; set; }
        public string Item3 { get; set; }
        public string DeptName { get; set; }
    }
}
