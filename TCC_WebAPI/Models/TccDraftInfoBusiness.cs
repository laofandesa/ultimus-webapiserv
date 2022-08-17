using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDraftInfoBusiness
    {
        public int Id { get; set; }
        public int? Diid { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Description { get; set; }
        public string Operator { get; set; }
        public string OperatorLoginName { get; set; }
    }
}
