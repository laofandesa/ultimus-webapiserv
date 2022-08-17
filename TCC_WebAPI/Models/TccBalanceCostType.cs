using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBalanceCostType
    {
        public int Id { get; set; }
        public int? TypeCode { get; set; }
        public string TypeName { get; set; }
        public int? IsEnable { get; set; }
        public string GroupName { get; set; }
        public string ProjectType { get; set; }
        public int? SortValue { get; set; }
        public string SubjectCodes { get; set; }
    }
}
