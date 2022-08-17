using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class BaseTable
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Cdate { get; set; }
    }
}
