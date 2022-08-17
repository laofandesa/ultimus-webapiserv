using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDeptBudgetEditLog
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public string DeptCode { get; set; }
        public string BdgCode { get; set; }
        public string BdgType { get; set; }
        public DateTime CreateDate { get; set; }
        public int Flag { get; set; }
        public string Guid { get; set; }
    }
}
