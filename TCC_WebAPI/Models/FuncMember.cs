using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class FuncMember
    {
        public int Id { get; set; }
        public int FuncItemId { get; set; }
        public int MemberType { get; set; }
        public string MemberName { get; set; }
        public string MemberAccount { get; set; }
    }
}
