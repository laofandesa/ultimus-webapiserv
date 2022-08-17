using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSystemQueryDict
    {
        public int Id { get; set; }
        public string DataType { get; set; }
        public string DataName { get; set; }
        public string DataValue { get; set; }
        public int? ShowOrder { get; set; }
    }
}
