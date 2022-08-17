using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewVehicleDeptCostMonth
    {
        public string UseDeptId { get; set; }
        public string DeptName { get; set; }
        public string UseMonth { get; set; }
        public decimal? CompFare { get; set; }
    }
}
