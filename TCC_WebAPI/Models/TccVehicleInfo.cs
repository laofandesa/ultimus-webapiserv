using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccVehicleInfo
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string FormNumber { get; set; }
        public DateTime? RequestDate { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyTelephone { get; set; }
        public string ApplyMobile { get; set; }
        public string ApplyEmail { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public int? ApplyType { get; set; }
        public string CardNo { get; set; }
        public string People { get; set; }
        public string MagerKey { get; set; }
        public string MagerUserKey { get; set; }
        public string MagerUser { get; set; }
        public int? IsLong { get; set; }
        public string ReasonInfo { get; set; }
        public string ApplyReason { get; set; }
        public string UseDept { get; set; }
        public string UseDeptId { get; set; }
        public string DeptManagerName { get; set; }
        public string ProjectNo { get; set; }
        public string ProjectName { get; set; }
        public string UseSite { get; set; }
        public string ProjectManagerName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string StartSite { get; set; }
        public string AimSite { get; set; }
        public string BoardSite { get; set; }
        public DateTime? LeaveTime { get; set; }
        public string OwnerInfo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPos { get; set; }
        public string ProjectInfo { get; set; }
        public int? DriverId { get; set; }
        public string DriverName { get; set; }
        public string CarNumber { get; set; }
        public string CarType { get; set; }
        public decimal? Price { get; set; }
        public string DriverPhone { get; set; }
        public string VehicleBong { get; set; }
        public string VehicleUseCom { get; set; }
        public string ContratBelong { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string MailesInterval { get; set; }
        public int? CarMiles { get; set; }
        public string WaitMails { get; set; }
        public decimal? CarFare { get; set; }
        public decimal? RoadFare { get; set; }
        public decimal? ReceFare { get; set; }
        public decimal? AcceptFare { get; set; }
        public string Operationer { get; set; }
        public int? Flag { get; set; }
        public string FlagInfo { get; set; }
    }
}
