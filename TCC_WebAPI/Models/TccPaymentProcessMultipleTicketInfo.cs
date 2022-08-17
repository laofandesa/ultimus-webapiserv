using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessMultipleTicketInfo
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string SelectRealName { get; set; }
        public string SelectLoginName { get; set; }
        public string SelectSfzh { get; set; }
        public DateTime? ActiveDate { get; set; }
        public string FromPlace { get; set; }
        public string ToPlace { get; set; }
        public int? IsReturn { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string StrokeNumber { get; set; }
        public decimal? Price { get; set; }
        public string ExpenseClaimFormNumber { get; set; }
        public string BusinessAskForLeaveFormNumber { get; set; }
        public string PersonDeptCode { get; set; }
        public string PersonDeptName { get; set; }
        public string AccountProject { get; set; }
        public string AccountProjectName { get; set; }
        public string AccountDept { get; set; }
        public string TravelingPeople { get; set; }
        public int? VoyageType { get; set; }
        public string AirlineCompany { get; set; }
        public string FlightNumber { get; set; }
        public string BillCode { get; set; }
        public string SeatRank { get; set; }
        public decimal? FlightPrice { get; set; }
        public decimal? FuelSurcharge { get; set; }
    }
}
