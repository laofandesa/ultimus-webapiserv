using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigBasicOption
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? UseCategoryId { get; set; }
        public int? Enabled { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public string PowerDept { get; set; }
        public string PowerRole { get; set; }
    }
}
