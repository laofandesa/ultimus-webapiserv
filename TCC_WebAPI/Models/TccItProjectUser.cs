using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccItProjectUser
    {
        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public string Account { get; set; }
        public string DeptNo { get; set; }
        public string DeptName { get; set; }
        public string Name { get; set; }
        public string UserRole { get; set; }
        public string UserTask { get; set; }
        public string UserFlag { get; set; }
    }
}
