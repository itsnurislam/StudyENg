using System;
using System.Collections.Generic;

namespace StudEng.Models
{
    public partial class User
    {
        public int? IdUser { get; set; }
        public string? Login { get; set; } = null!;
        public string? Password { get; set; } = null!;
    }
}
