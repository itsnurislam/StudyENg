using System;
using System.Collections.Generic;

namespace StudEng.Models
{
    public partial class Pupil
    {
        public int? IdPupil { get; set; }
        public string? FirstNamePupil { get; set; } = null!;
        public string? SecondNamePupil { get; set; } = null!;
        public string? MiddleNamePupil { get; set; }
        public string? LoginPupil { get; set; } = null!;
        public string? PasswrodPupil { get; set; } = null!;
        public int? OwnNumber { get; set; }
        public int? ModulleId { get; set; }

    }
}
