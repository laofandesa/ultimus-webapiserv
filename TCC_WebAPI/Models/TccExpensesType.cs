using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExpensesType
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? Level { get; set; }
        public string ParentCode { get; set; }
        public string SubNameMc { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ScopeOfProject { get; set; }
        public string ScopeOfDept { get; set; }
        public string SubJectCode { get; set; }
    }
}
