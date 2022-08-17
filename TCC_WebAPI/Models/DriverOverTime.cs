using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class DriverOverTime
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string FormNumber { get; set; }
        public string Name { get; set; }
        public string Namekey { get; set; }
        public int? Carmiles { get; set; }
        public decimal? Everymilestandard { get; set; }
        public decimal? Milemoney { get; set; }
        public int? Businessdays { get; set; }
        public decimal? Businessstandard { get; set; }
        public decimal? Businessmoney { get; set; }
        public int? Weekdays { get; set; }
        public decimal? Weekstandard { get; set; }
        public decimal? Weekmoney { get; set; }
        public int? Everydays { get; set; }
        public decimal? Everystandard { get; set; }
        public decimal? Everymoney { get; set; }
        public int? Wholedays { get; set; }
        public decimal? Wholestandard { get; set; }
        public decimal? Wholemoney { get; set; }
        public int? Holidays { get; set; }
        public decimal? Holidaystandard { get; set; }
        public decimal? Holidaymoney { get; set; }
        public int? Alldays { get; set; }
        public decimal? Alldaystandard { get; set; }
        public decimal? Alldaymoney { get; set; }
        public int? Nightdays { get; set; }
        public decimal? Nightstandard { get; set; }
        public decimal? Nightsmoney { get; set; }
        public decimal? Allmoney { get; set; }
        public DateTime? TimeMonth { get; set; }
    }
}
