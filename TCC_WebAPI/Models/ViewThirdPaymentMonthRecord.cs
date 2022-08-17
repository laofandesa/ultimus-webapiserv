using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewThirdPaymentMonthRecord
    {
        public string VProcessName { get; set; }
        public int? VIncident { get; set; }
        public int SFlag { get; set; }
        public string Digest { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
    }
}
