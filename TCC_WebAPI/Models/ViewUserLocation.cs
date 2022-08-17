using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewUserLocation
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public string UserName { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public bool? IsTj { get; set; }
    }
}
