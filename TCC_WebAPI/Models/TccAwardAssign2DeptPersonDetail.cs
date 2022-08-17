using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAwardAssign2DeptPersonDetail
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string UserLoginName { get; set; }
        public string UserRealName { get; set; }
        public string UserIdentity { get; set; }
        public decimal? CanDoPerson { get; set; }
    }
}
