using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPrintApplyUser
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int? UserOrgid { get; set; }
        public int? UserRoleid { get; set; }
    }
}
