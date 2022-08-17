using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewFinanceReceiveAmountInfo
    {
        public string ProcessName { get; set; }
        public int Incident { get; set; }
        public int ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCategory { get; set; }
        public string ProjectCategorySub { get; set; }
        public string ProjectJnw { get; set; }
        public string PayCmpName { get; set; }
        public string PayCmpCode { get; set; }
        public DateTime? ProcessFinish { get; set; }
        public DateTime? StartDate { get; set; }
        public int DfconfimStatus { get; set; }
        public string RequestFormNumber { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal? Telamount { get; set; }
        public decimal? Dfamount { get; set; }
    }
}
