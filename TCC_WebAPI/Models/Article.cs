using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
