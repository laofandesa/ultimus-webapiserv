using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmDict
    {
        public int Id { get; set; }
        public string DateType { get; set; }
        public string DateName { get; set; }
        public string DateValue { get; set; }
        public int? DateOrder { get; set; }
        public string DateBelong { get; set; }
    }
}
