using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAwardUserRelation
    {
        public int Id { get; set; }
        public string AwardCategory { get; set; }
        public string HrpCodeItem { get; set; }
        public string HrpCodeItemDesc { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserLoginName { get; set; }
        public string CreateUserRealName { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateLoginName { get; set; }
        public string UpdateRealName { get; set; }
    }
}
