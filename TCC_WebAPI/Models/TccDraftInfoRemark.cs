using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDraftInfoRemark
    {
        public int Id { get; set; }
        public int? Diid { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Creator { get; set; }
        public string CreatorLoginName { get; set; }
        public string Remark { get; set; }
    }
}
