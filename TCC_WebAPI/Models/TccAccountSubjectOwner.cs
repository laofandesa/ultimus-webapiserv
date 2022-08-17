using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAccountSubjectOwner
    {
        public int Id { get; set; }
        public int? OwnerId { get; set; }
        public string OwnerType { get; set; }
    }
}
