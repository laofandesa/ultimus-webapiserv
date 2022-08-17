using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccVehicleSeat
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string VehicleCategory { get; set; }
        public int? Code { get; set; }
        public string SeatName { get; set; }
        public string CreateUserLoginName { get; set; }
        public string CreateUserRealName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateUserLoginName { get; set; }
        public string UpdateUserRealName { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? IsEnabled { get; set; }
    }
}
