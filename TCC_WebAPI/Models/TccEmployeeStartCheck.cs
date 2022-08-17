using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccEmployeeStartCheck
    {
        public int Id { get; set; }
        public string CheckId { get; set; }
        public string CheckUser { get; set; }
        public string CheckUserKey { get; set; }
        public string CheckRemark { get; set; }
        public int? CheckType { get; set; }
        public double? CheckScore { get; set; }
    }
}
