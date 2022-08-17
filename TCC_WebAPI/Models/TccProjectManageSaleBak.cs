using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectManageSaleBak
    {
        public int Id { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? AmountYb { get; set; }
        public string Currency { get; set; }
        public string Digest { get; set; }
        public string Item6 { get; set; }
    }
}
