using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccGuaranteeLetterHeader
    {
        public TccGuaranteeLetterHeader()
        {
            TccGuaranteeLetterPrjInfos = new HashSet<TccGuaranteeLetterPrjInfo>();
        }

        public string Glid { get; set; }
        public string ProcessName { get; set; }
        public int Incident { get; set; }
        public int PaperStatus { get; set; }
        public int ProcessStatus { get; set; }
        public string FormNumber { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string UserIdentity { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestUserProfessional { get; set; }
        public string OppositeCode { get; set; }
        public string VoucherId { get; set; }
        public string ConfirmFinaceLoginName { get; set; }
        public string ConfirmFinaceName { get; set; }
        public string AuditAccountLoginName { get; set; }
        public string AuditAccountName { get; set; }
        public string ConfirmFinaceIdnumber { get; set; }
        public string AuditAccountIdnumber { get; set; }

        public virtual ICollection<TccGuaranteeLetterPrjInfo> TccGuaranteeLetterPrjInfos { get; set; }
    }
}
