using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmPersonalManagePhoneCard
    {
        public int Id { get; set; }
        public string HomePhone { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string EmyPhone { get; set; }
        public string HomeLocation { get; set; }
        public string MailNumber { get; set; }
        public int PmFk { get; set; }
    }
}
