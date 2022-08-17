using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccCardUserList
    {
        public int Id { get; set; }
        public int? Incident { get; set; }
        public string UserListName { get; set; }
        public string UserListCompany { get; set; }
        public string UserListForeignComp { get; set; }
        public string UserListCode { get; set; }
        public string FormNumber { get; set; }
        public string ApplyLogin { get; set; }
    }
}
