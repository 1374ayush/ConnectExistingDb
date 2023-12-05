using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class BookDetail
    {
        public int BookId { get; set; }
        public string Name { get; set; } = null!;
        public int Rating { get; set; }
        public string Author { get; set; } = null!;
        public string Gener { get; set; } = null!;
        public bool BookAvailability { get; set; }
        public string Description { get; set; } = null!;
        public int LendBy { get; set; }
        public int BorrowedBy { get; set; }
    }
}
