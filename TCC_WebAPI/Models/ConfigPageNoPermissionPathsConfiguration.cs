using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigPageNoPermissionPathsConfiguration
    {
        public int Id { get; set; }
        public string NoAuthPath { get; set; }
        public int? Enabled { get; set; }
    }
}
