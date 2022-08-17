using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewQueryGrtLtInfo
    {
        public string MessageName { get; set; }
        public int SendType { get; set; }
        public string CreateLoginName { get; set; }
        public string RequestDeptCode { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ContractCode { get; set; }
        public string HdId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string OpenEnt { get; set; }
        public string UnitName { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
