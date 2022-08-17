using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmPersonalManageGjjcard
    {
        public int Id { get; set; }
        public int PmFk { get; set; }
        public string RzChangeFlag { get; set; }
        public string RzChangeFlagId { get; set; }
        public string RzBxhdjs { get; set; }
        public string RzGjjhdjs { get; set; }
        public string RzBxjfdd { get; set; }
        public string RzBxjfddid { get; set; }
        public string RzGjjjfdd { get; set; }
        public string RzGjjjfddid { get; set; }
    }
}
