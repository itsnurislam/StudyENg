using System;
using System.Collections.Generic;

namespace StudEng.Models
{
    public partial class Course
    {
        public int? IdCourses { get; set; }
        public string? Elementary { get; set; } = null!;
        public string? Intermediate { get; set; } = null!;
        public string? PreIntermediate { get; set; } = null!;
        public string? Advanced { get; set; } = null!;
        public int? SaleId { get; set; }

    }
}
