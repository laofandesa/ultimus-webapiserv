using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccCwAccountsubject
    {
        public string Unitid { get; set; }
        public string Zt { get; set; }
        public string Orgname { get; set; }
        public string Kmcode { get; set; }
        public string Kmmc { get; set; }
        public string Asstype { get; set; }
        public string Showname { get; set; }
        public int? Level { get; set; }
        public int Acctyear { get; set; }
    }
}
