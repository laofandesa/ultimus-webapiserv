using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class Bpmsapplog20180906
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string Thread { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string MethodName { get; set; }
        public string FolderName { get; set; }
        public string PathName { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
    }
}
