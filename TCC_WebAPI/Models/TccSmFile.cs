using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSmFile
    {
        public int Id { get; set; }
        public string FileDept { get; set; }
        public string ProgressCode { get; set; }
        public string FileCode { get; set; }
        public string FileVersion { get; set; }
        public string FileType { get; set; }
        public string FileId { get; set; }
        public string FileName { get; set; }
        public string FileRegName { get; set; }
        public string FileRegId { get; set; }
        public DateTime? PubDate { get; set; }
        public int? FileAtt { get; set; }
    }
}
