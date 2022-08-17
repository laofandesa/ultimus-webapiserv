using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class CommonDic
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Label { get; set; }
        public string Type { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsEnabled { get; set; }
        public int? ParentId { get; set; }
        public int OrderVal { get; set; }
    }
}
