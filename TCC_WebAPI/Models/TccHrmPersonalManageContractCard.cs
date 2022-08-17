using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmPersonalManageContractCard
    {
        public int Id { get; set; }
        public int PmFk { get; set; }
        public string WkContractNo { get; set; }
        public string WkContractFlag { get; set; }
        public string WkContractFlagId { get; set; }
        public string WkContractBeginDate { get; set; }
        public string WkContractEndDate { get; set; }
        public string WkContractSignDate { get; set; }
        public string WkProbationEndDate { get; set; }
        public string WkIsSecret { get; set; }
        public string WkIsSecretId { get; set; }
        public string WkConcractDeadline { get; set; }
        public string WkConcractDeadlineId { get; set; }
        public string WkProbation { get; set; }
        public string WkProbationId { get; set; }
    }
}
