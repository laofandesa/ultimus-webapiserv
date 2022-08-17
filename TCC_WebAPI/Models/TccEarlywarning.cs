using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccEarlywarning
    {
        public string Title { get; set; }
        public string MsgTitle { get; set; }
        public string ReceiveUser { get; set; }
        public string Thirdpartyid { get; set; }
        public string MessageName { get; set; }
        public int? SendType { get; set; }
        public string GrtLtCode { get; set; }
    }
}
