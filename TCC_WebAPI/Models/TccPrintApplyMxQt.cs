using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPrintApplyMxQt
    {
        public string FormNumber { get; set; }
        public string QtLiang { get; set; }
        public string QtGongri { get; set; }
        public string QtCaozuoren { get; set; }
        public int Qtid { get; set; }
        public string QtServiceType { get; set; }
        public string QtServiceTypeId { get; set; }
        public string QtLwName { get; set; }
        public string QtLwSl { get; set; }
        public string QtQuestion { get; set; }
        public string QtGgfwCont { get; set; }
        public string QtGgfwRs { get; set; }
        public string QtGgfwGs { get; set; }
        public string QtYqwcsj { get; set; }
        public string QtFeiyong { get; set; }
        public int? QtParentId { get; set; }
        public string State { get; set; }
        public string QtCaozuorenId { get; set; }
    }
}
