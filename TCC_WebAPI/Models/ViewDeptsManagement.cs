using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewDeptsManagement
    {
        public string DeptId { get; set; }
        public int? DeptIdentityId { get; set; }
        public string DeptCode { get; set; }
        public string DeptThirdPartId { get; set; }
        public string DeptMasterPositionId { get; set; }
        public string DeptName { get; set; }
        public int? DeptSort { get; set; }
        public string DeptRemark { get; set; }
    }
}
