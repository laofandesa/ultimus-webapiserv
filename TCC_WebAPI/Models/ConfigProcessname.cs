using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigProcessname
    {
        public int Id { get; set; }
        public string UltimusProcessName { get; set; }
        public string ShowProcessName { get; set; }
        public int? IsDelete { get; set; }
    }
}
