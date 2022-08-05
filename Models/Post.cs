using System;
using System.Collections.Generic;

namespace Huhuhu.Models
{
    public partial class Post
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public string? Image { get; set; }
        public string? Content { get; set; }
        public DateTime? CreateAt { get; set; }
    }
}
