using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPartyMoneyInitialization
    {
        public int Id { get; set; }
        public string UserIdentityId { get; set; }
        public decimal? PartyMoney { get; set; }
        public string UserName { get; set; }
        public string PartyName { get; set; }
        public string DeptName { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
    }
}
