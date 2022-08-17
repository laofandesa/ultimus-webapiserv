using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccMonthlyforHouseSubsidy
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public int? Year { get; set; }
        public int? Quarter { get; set; }
        public int? Month { get; set; }
        public string EducationLevel { get; set; }
        public int? Category { get; set; }
        public decimal? Standard { get; set; }
        public string CreateDate { get; set; }
    }
}
