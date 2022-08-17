using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccEmployeeCheckScore
    {
        public int Id { get; set; }
        public string CheckId { get; set; }
        public string CheckUserKey { get; set; }
        public int? ScoreId { get; set; }
        public double? CheckScore { get; set; }
    }
}
