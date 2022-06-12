using System;
using System.Collections.Generic;

namespace rrt.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public bool RememberMe { get; set; }
    }
}
