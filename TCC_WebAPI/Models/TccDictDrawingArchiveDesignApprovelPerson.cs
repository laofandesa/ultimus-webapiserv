using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDictDrawingArchiveDesignApprovelPerson
    {
        public string UserName { get; set; }
        public string UserLoginName { get; set; }
        public string DeptName { get; set; }
        public string DeptNo { get; set; }
        public int? Year { get; set; }
        public string Kind { get; set; }
    }
}
