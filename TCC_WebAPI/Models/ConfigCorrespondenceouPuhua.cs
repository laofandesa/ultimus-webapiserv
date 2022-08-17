using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigCorrespondenceouPuhua
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Code { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string ProjectType { get; set; }
        public int? IsYf { get; set; }
    }
}
