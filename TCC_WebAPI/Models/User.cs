using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class User
    {
        public User()
        {
            Articles = new HashSet<Article>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
