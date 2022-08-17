using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class UbscPlanItemsSource
    {
        public Guid UbscPlanItemsSourceOid { get; set; }
        public string SourceName { get; set; }
        public string Remark { get; set; }
    }
}
