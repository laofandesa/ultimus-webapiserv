using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBusinessTripOfairInfo
    {
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string FormNumber { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string ProjectCode { get; set; }
        public string AccountProject { get; set; }
        public string AccountProjectName { get; set; }
        public string AccountDept { get; set; }
        public int? ToDomesticOversea { get; set; }
        public string Toplace { get; set; }
        public string TravelDate { get; set; }
    }
}
