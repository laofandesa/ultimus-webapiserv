using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class PassPortInfo
    {
        public int Id { get; set; }
        public string UserKey { get; set; }
        public string Name { get; set; }
        public DateTime? BornDate { get; set; }
        public string BornPlace { get; set; }
        public string PassportTypeNo { get; set; }
        public string PassportCode { get; set; }
        public DateTime? PassportSign { get; set; }
        public DateTime? PassportValid { get; set; }
        public string PassportStatus { get; set; }
        public string OrganInfo { get; set; }
        public string SignSite { get; set; }
        public string FileNo { get; set; }
        public string CardStatus { get; set; }
        public string Country { get; set; }
    }
}
