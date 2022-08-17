using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewDepartment
    {
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentType { get; set; }
        public string Company { get; set; }
        public string AcountLocation { get; set; }
        public int IsAbroad { get; set; }
    }
}
