using System;
using System.Collections.Generic;

namespace StudEng.Models
{
    public partial class Employee
    {
        public int? IdEmployee { get; set; }
        public string? FirstNameEmployee { get; set; } = null!;
        public string? SecondNameEmployee { get; set; } = null!;
        public string? MiddleNameEmployee { get; set; }
        public string? LoginEmployee { get; set; } = null!;
        public string? PasswrodEmployee { get; set; } = null!;
        public int? ModulleId { get; set; }

    }
}
