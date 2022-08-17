using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccOperatingAndBusinessSupportVehicleBudgetTemp
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string Type { get; set; }
        public string VehicleBrand { get; set; }
        public string Model { get; set; }
        public decimal? PurchaseCostExcludingTax { get; set; }
        public decimal? RelatedTaxesAndExpenses { get; set; }
        public int? Count { get; set; }
        public decimal? TotalPurchaseCostIncludingTax { get; set; }
        public decimal? TotalPurchaseCostExcludingTax { get; set; }
        public string PurchasePurpose { get; set; }
        public string DecreaseAndIncrease { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string MakeUnit { get; set; }
    }
}
