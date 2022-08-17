using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaDeptOthersPadetail
    {
        public long Id { get; set; }
        public string OthersPaName { get; set; }
        public string OthersPaPointZdx { get; set; }
        public string OthersPaPointXysj { get; set; }
        public string OthersPaPointJjwtsj { get; set; }
        public string OthersPaPointXxfksj { get; set; }
        public string OthersPaPointFwzl { get; set; }
        public string OthersPaPointTotal { get; set; }
        public long? OthersPaFk { get; set; }
        public string EvaluateName { get; set; }
        public string EvaluateYear { get; set; }
    }
}
