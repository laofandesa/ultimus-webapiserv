using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccStandardforHouseSubsidy
    {
        public int Id { get; set; }
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public string EducationLevel { get; set; }
        public int? Category { get; set; }
        public decimal? Standard { get; set; }
        public DateTime? AlterDate { get; set; }
    }
}
