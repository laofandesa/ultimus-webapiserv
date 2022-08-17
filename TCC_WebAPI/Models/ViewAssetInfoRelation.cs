using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewAssetInfoRelation
    {
        public string GclassCode { get; set; }
        public string GclassName { get; set; }
        public string PclassCode { get; set; }
        public string PclassName { get; set; }
        public string CclassCode { get; set; }
        public string CclassName { get; set; }
        public string DeptRange { get; set; }
        public string ManageDept { get; set; }
        public string ManageDeptName { get; set; }
    }
}
