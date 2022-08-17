using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewAbroadUserInfo
    {
        public string CompName { get; set; }
        public string DeptName { get; set; }
        public string Name { get; set; }
        public int? Sex { get; set; }
        public string PassportCode { get; set; }
        public decimal? PostGrade { get; set; }
        public string Title { get; set; }
        public string UserKey { get; set; }
        public DateTime? BornDate { get; set; }
        public string BornPlace { get; set; }
        public string DeptNo { get; set; }
        public string Company { get; set; }
        public string DepartmentType { get; set; }
        public string FormNumber { get; set; }
        public string C012o { get; set; }
        public string Codeitemdesc { get; set; }
    }
}
