using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewUserDept
    {
        public string IdentityId { get; set; }
        public string ReceiverUserName { get; set; }
        public string Cardholder { get; set; }
        public string DeptCode { get; set; }
        public string Dept { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
    }
}
