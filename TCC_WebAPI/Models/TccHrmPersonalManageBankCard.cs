using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmPersonalManageBankCard
    {
        public int Id { get; set; }
        public string PersonName { get; set; }
        public string WageCardNo { get; set; }
        public string WageCardvalid { get; set; }
        public string WageCardMdfDate { get; set; }
        public string CreditCardNo { get; set; }
        public string CreditCardvalid { get; set; }
        public string CreditCardMdfDate { get; set; }
        public int PmFk { get; set; }
    }
}
