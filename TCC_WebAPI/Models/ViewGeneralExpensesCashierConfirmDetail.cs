using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewGeneralExpensesCashierConfirmDetail
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string Bxr { get; set; }
        public string Bxridnumber { get; set; }
        public string Bxrcode { get; set; }
        public string Jbr { get; set; }
        public string Jbridnumber { get; set; }
        public string Jbrcode { get; set; }
    }
}
