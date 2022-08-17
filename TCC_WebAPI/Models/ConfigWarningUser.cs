using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigWarningUser
    {
        public int SendType { get; set; }
        public int NotifyBeginer { get; set; }
        public int NotifyDeptManager { get; set; }
        public int NotifyCtlManager { get; set; }
        public int NotifyProManager { get; set; }
        public int NotifyFnManager { get; set; }
        public int IsEnabled { get; set; }
        public int IsDel { get; set; }
    }
}
