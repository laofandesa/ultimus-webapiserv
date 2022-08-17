using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmPersonalManageZzcard
    {
        public int Id { get; set; }
        public int PmFk { get; set; }
        public string RegistOrg { get; set; }
        public string RegistOrgId { get; set; }
        public string ApprovelOrg { get; set; }
        public string BookName { get; set; }
        public string BookNameId { get; set; }
        public string BookType { get; set; }
        public string ApprovelDate { get; set; }
        public string SignDate { get; set; }
        public string GetWay { get; set; }
        public string GetWayId { get; set; }
        public string BookNo { get; set; }
        public string RegistDate { get; set; }
        public string SealNo { get; set; }
        public string ValiDate { get; set; }
        public string SubsidyStandard { get; set; }
        public string SubsidyOrg { get; set; }
        public string SubsidyOrgId { get; set; }
        public string SubsidyBeginDate { get; set; }
        public string AllowRange { get; set; }
        public string SubmitDate { get; set; }
        public string BookLevel { get; set; }
        public string MainMajor { get; set; }
        public string AidMajor { get; set; }
        public string RegistPlace { get; set; }
        public string ContiueEdu { get; set; }
        public string CompanySave { get; set; }
        public string PersonalSave { get; set; }
        public string BookRemark { get; set; }
        public string BookNameNo { get; set; }
    }
}
