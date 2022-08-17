using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewVehicleProjectCostMonth
    {
        public string ProjectNo { get; set; }
        public string ProjectName { get; set; }
        public string UseMonth { get; set; }
        public decimal? CompFare { get; set; }
    }
}
