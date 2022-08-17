using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewHrpAllDepartment
    {
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string ParentDeptCode { get; set; }
        public string ChildDept { get; set; }
        public int? DeptLevel { get; set; }
    }
}
