using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class BSqlConfig
    {
        public int ScId { get; set; }
        public string ScDataName { get; set; }
        public int ScDataDoType { get; set; }
        public string ScFiledName { get; set; }
        public string ScTableName { get; set; }
        public string ScWhere { get; set; }
        public string ScOrderSort { get; set; }
        public string ScKeyFiled { get; set; }
        public int? ScKeyFiledType { get; set; }
        public string ScFunctionName { get; set; }
        public string ScModuleName { get; set; }
        public string ScSummary { get; set; }
        public int? ScIsSystem { get; set; }
    }
}
