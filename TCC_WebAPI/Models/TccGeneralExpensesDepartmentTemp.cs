using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccGeneralExpensesDepartmentTemp
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string ExpenseType { get; set; }
        public int? ExpenseTypeCode { get; set; }
        public string ProjectCode { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public decimal? PaymentAmount { get; set; }
        public string Requestor { get; set; }
        public int? Flag { get; set; }
    }
}
