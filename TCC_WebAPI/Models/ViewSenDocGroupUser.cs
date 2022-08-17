using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewSenDocGroupUser
    {
        public string Username { get; set; }
        public string Userid { get; set; }
        public string Deptid { get; set; }
        public string Deptname { get; set; }
        public string Groupname { get; set; }
        public int? Groupid { get; set; }
    }
}
