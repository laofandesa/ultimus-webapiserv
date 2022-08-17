using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSalaryAdjustmentPlan
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public string IdentityId { get; set; }
        public string UserName { get; set; }
        public string Dept { get; set; }
        public string OrinigalPostName { get; set; }
        public string NewPostName { get; set; }
        public decimal? OrinigalSalaryLevel { get; set; }
        public decimal? NewSalaryLevel { get; set; }
        public decimal? StableSalary { get; set; }
        public decimal? PostAllowance { get; set; }
        public decimal? OrinigalReservationWages { get; set; }
        public decimal? NewReservationWages { get; set; }
        public string OrinigalPostCode { get; set; }
        public string NewPostCode { get; set; }
        public DateTime? UploadDate { get; set; }
        public int? IsUpdated { get; set; }
    }
}
