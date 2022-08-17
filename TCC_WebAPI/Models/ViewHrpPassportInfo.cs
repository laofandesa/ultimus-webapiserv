using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewHrpPassportInfo
    {
        public string PassportTypeNo { get; set; }
        public string A0100 { get; set; }
        public string E0122 { get; set; }
        public string UserKey { get; set; }
        public string Name { get; set; }
        public string DeptName { get; set; }
        public string PassportCode { get; set; }
        public DateTime? PassportSign { get; set; }
        public DateTime? PassportValid { get; set; }
        public string OrganInfo { get; set; }
        public string Nationality { get; set; }
        public string SignSite { get; set; }
        public string FileCode { get; set; }
        public DateTime BornDate { get; set; }
        public string BornPlace { get; set; }
        public string PassportStatus { get; set; }
        public string Expr1 { get; set; }
        public string Expr2 { get; set; }
    }
}
