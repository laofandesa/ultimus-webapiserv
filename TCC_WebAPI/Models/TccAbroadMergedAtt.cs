using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAbroadMergedAtt
    {
        public int Id { get; set; }
        public string FormNumber { get; set; }
        public string ChildFormNumber { get; set; }
        public string Tvcountry { get; set; }
    }
}
