﻿using System;
using System.Collections.Generic;

namespace Huhuhu.Models
{
    public partial class User
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Email { get; set; }
    }
}
