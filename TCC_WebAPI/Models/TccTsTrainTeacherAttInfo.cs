using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTsTrainTeacherAttInfo
    {
        public int Id { get; set; }
        public int? TeacherFk { get; set; }
        public string AttFileName { get; set; }
        public string AttFileId { get; set; }
    }
}
