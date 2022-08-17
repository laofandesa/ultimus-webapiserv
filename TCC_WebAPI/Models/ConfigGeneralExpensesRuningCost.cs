using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigGeneralExpensesRuningCost
    {
        public int Id { get; set; }
        public string DeptType { get; set; }
        public string SubName { get; set; }
        public string SubjectName { get; set; }
        public string ExpenseName { get; set; }
        public int? IsEnabled { get; set; }
        public int? Type { get; set; }
        public int? PayType { get; set; }
        public string SubjectType { get; set; }
        public int? GroupNumber { get; set; }
    }
}
