using System;
using System.Collections.Generic;

namespace Huhuhu.Models
{
    public partial class PostLofe
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string InteractiveUser { get; set; } = null!;
        public DateTime? CreateAt { get; set; }
    }
}
