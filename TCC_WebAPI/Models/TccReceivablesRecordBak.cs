using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccReceivablesRecordBak
    {
        public int Id { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public string ContractDate { get; set; }
        public string DeptName { get; set; }
        public string DeptCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectType { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectManagerLoginName { get; set; }
        public string ProjectManagerId { get; set; }
        public string BusinessManager1 { get; set; }
        public string BusinessManagerLoginName1 { get; set; }
        public string BusinessManagerId1 { get; set; }
        public string BusinessManager2 { get; set; }
        public string BusinessManagerLoginName2 { get; set; }
        public string BusinessManagerId2 { get; set; }
        public string ReceiveType { get; set; }
        public decimal? ReceiveAmount { get; set; }
        public string Currency { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string ReceiveMethod { get; set; }
        public int? ReceiveMethodId { get; set; }
        public string ContractType { get; set; }
        public int? ContractTypeId { get; set; }
        public int? IncidentNo { get; set; }
        public string ProcessName { get; set; }
        public int? Status { get; set; }
        public int? Rpid { get; set; }
        public string RequestLoginName { get; set; }
        public string RequsetSfzh { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string RequestRealName { get; set; }
        public string RequestDate { get; set; }
        public string RequestFormNumber { get; set; }
        public DateTime? ReceivablesTime { get; set; }
        public DateTime? AccountingTime { get; set; }
        public string Handing { get; set; }
        public string HandingIdnumber { get; set; }
        public string Operater { get; set; }
        public string OperaterIdnumber { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? ChangeLocalCurrencyAmount { get; set; }
        public decimal? Exchange { get; set; }
    }
}
