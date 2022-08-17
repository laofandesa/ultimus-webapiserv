using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDictDocument
    {
        public int Id { get; set; }
        public string DateType { get; set; }
        public string DateName { get; set; }
        public string DateVaule { get; set; }
        public int? ParentId { get; set; }
        public int? DateLevel { get; set; }
    }
}
