using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigDepartmentAccount
    {
        public int Id { get; set; }
        public string DepartmentCode { get; set; }
        public string SubjectType { get; set; }
        public string SubjectTypeName { get; set; }
    }
}
