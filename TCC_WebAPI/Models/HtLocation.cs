using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class HtLocation
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string Path { get; set; }
        public string Level { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string NamePinyin { get; set; }
        public string Code { get; set; }
    }
}
