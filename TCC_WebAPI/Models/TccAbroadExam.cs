using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAbroadExam
    {
        public int? Id { get; set; }
        public string FormNumber { get; set; }
        public string UserKey { get; set; }
        public decimal? Score { get; set; }
        public DateTime? RequestDate { get; set; }
    }
}
