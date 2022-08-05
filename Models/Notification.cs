using System;
using System.Collections.Generic;

namespace Huhuhu.Models
{
    public partial class Notification
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string InteractiveUser { get; set; } = null!;
        public string Message { get; set; } = null!;
        public bool? IsRead { get; set; }
        public DateTime? CreateAt { get; set; }
    }
}
