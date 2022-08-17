using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccComputerUser
    {
        public int Id { get; set; }
        public string UserDeptName { get; set; }
        public string UserPosType { get; set; }
        public string JobMajor { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public string ComputerType { get; set; }
        public string UserKey { get; set; }
    }
}
