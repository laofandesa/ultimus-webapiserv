using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAbroadCertiInfoRecord
    {
        public int Id { get; set; }
        public string CardNo { get; set; }
        public string CardStatus { get; set; }
        public string Name { get; set; }
        public string FormNumber { get; set; }
        public DateTime? LendDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? AbroadType { get; set; }
        public string AimCountry { get; set; }
        public int? AimDays { get; set; }
        public string AimRoadInfo { get; set; }
        public string DepartTime { get; set; }
        public string HomeTime { get; set; }
        public string HandleUser { get; set; }
        public DateTime? OperateDate { get; set; }
        public string LendReson { get; set; }
        public string ReturnReson { get; set; }
        public string IsReleate { get; set; }
    }
}
