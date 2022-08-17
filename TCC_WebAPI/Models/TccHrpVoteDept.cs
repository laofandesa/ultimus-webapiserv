using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrpVoteDept
    {
        public int Id { get; set; }
        public int? SortNumber { get; set; }
        public string DeptType { get; set; }
        public string DeptName { get; set; }
        public string DeptCode { get; set; }
    }
}
