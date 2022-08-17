using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccComputerDept
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public string DpetNo { get; set; }
        public string DeptType { get; set; }
        public string DeptTypeNo { get; set; }
    }
}
