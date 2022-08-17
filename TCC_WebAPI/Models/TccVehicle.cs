using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccVehicle
    {
        public int Id { get; set; }
        public string CarNumber { get; set; }
        public string CarType { get; set; }
        public string VehicleBong { get; set; }
        public string VehicleUseCom { get; set; }
        public bool? Type { get; set; }
        public bool? Status { get; set; }
        public decimal? Price { get; set; }
    }
}
