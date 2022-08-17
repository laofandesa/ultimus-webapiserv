using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class DriverOverStandard
    {
        public int Id { get; set; }
        public DateTime? StandardDate { get; set; }
        public decimal? Weekstandard { get; set; }
        public decimal? Everystandard { get; set; }
        public decimal? Wholestandard { get; set; }
        public decimal? Holidaystandard { get; set; }
        public decimal? Alldaystandard { get; set; }
        public decimal? Nightstandard { get; set; }
        public decimal? Everymilestandard { get; set; }
        public decimal? Businessstandard { get; set; }
    }
}
