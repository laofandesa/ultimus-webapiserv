using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewTccTravelItineraryOfPersonInfo
    {
        public string 报销单号 { get; set; }
        public string PersonLogin { get; set; }
        public string PersonRealName { get; set; }
        public string UserIdentity { get; set; }
        public string PersonDeptCode { get; set; }
        public string PersonDeptName { get; set; }
    }
}
