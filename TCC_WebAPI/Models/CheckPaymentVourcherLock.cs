using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class CheckPaymentVourcherLock
    {
        public int Id { get; set; }
        public int Incident { get; set; }
        public DateTime CreateDate { get; set; }
        public int LockStatus { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
