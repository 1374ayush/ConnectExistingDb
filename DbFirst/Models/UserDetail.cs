using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class UserDetail
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int BooksBorrowed { get; set; }
        public int BooksLent { get; set; }
        public int TokensAvailable { get; set; }
    }
}
