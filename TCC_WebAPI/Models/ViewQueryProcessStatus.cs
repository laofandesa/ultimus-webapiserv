using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewQueryProcessStatus
    {
        public string ProcessName { get; set; }
        public int Incident { get; set; }
        public string ConfirmPayment { get; set; }
    }
}
