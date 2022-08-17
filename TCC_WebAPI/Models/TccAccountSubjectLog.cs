using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAccountSubjectLog
    {
        public int Id { get; set; }
        public string Describition { get; set; }
        public DateTime? UpdatDate { get; set; }
        public string AlterName { get; set; }
        public string AlterLogin { get; set; }
        public string Category { get; set; }
    }
}
