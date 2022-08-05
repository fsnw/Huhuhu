using System;
using System.Collections.Generic;

namespace Huhuhu.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string InteractiveUser { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime? CreateAt { get; set; }
    }
}
