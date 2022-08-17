using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewEmployeeBasicInfo
    {
        public string A0100 { get; set; }
        public string 姓名 { get; set; }
        public string 身份证号 { get; set; }
        public string 部门 { get; set; }
        public string 学历 { get; set; }
        public DateTime? GraduateDate { get; set; }
        public string College { get; set; }
        public string Major { get; set; }
        public string Title { get; set; }
        public DateTime EnterDate { get; set; }
        public DateTime EnterJob { get; set; }
        public string Degree { get; set; }
        public string ContactNum { get; set; }
        public string ContactValid { get; set; }
        public string ContactDegree { get; set; }
        public string ContactDegree1 { get; set; }
    }
}
