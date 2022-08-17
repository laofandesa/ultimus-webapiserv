using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetBasicAccountDeparment
    {
        public int Id { get; set; }
        public string BdgCode { get; set; }
        public string DeptNo { get; set; }
        public string BdgType { get; set; }
    }
}
