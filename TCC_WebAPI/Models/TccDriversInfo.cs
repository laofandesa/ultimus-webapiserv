using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDriversInfo
    {
        public int Id { get; set; }
        public string DriverName { get; set; }
        public string UserKey { get; set; }
        public string DriverPhone { get; set; }
        public string CarNumber { get; set; }
        public double? Factor { get; set; }
        public DateTime? PlanStartTime { get; set; }
        public DateTime? PlanEndTime { get; set; }
        public int? IsUser { get; set; }
        public string CarType { get; set; }
        public string VehicleBong { get; set; }
        public string ContratBelong { get; set; }
        public string VehicleUseCom { get; set; }
    }
}
