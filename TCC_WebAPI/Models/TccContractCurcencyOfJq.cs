using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccContractCurcencyOfJq
    {
        public int Id { get; set; }
        public string CurcencyName { get; set; }
        public string CurcencyCode { get; set; }
        public string CurcencyAb { get; set; }
        public int? Decimaldigit { get; set; }
        public int? Operate { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? AlterTime { get; set; }
    }
}
