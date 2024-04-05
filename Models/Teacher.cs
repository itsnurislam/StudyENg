using System;
using System.Collections.Generic;

namespace StudEng.Models
{
    public partial class Teacher
    {
        public int? IdTeacher { get; set; }
        public string? FirstNameTeacher { get; set; } = null!;
        public string? SecondNameTeacher { get; set; } = null!;
        public string? MiddleNameTeacher { get; set; }
        public string? Level { get; set; } = null!;
        public int? ModulleId { get; set; }

        public virtual Modulle Modulle { get; set; } = null!;
    }
}
