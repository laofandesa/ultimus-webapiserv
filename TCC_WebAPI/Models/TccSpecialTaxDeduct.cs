using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSpecialTaxDeduct
    {
        public int Id { get; set; }
        public DateTime? CreatTime { get; set; }
        public string UserName { get; set; }
        public string IdentityId { get; set; }
        public DateTime? DeductStartDate { get; set; }
        public DateTime? DeductEndDate { get; set; }
        public decimal? DeductChildEducation { get; set; }
        public decimal? DeductSupportElderly { get; set; }
        public decimal? DeductContinueEducation { get; set; }
        public decimal? DeductHouseLoan { get; set; }
        public decimal? DeductHouseRent { get; set; }
    }
}
