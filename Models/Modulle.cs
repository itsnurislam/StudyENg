using System;
using System.Collections.Generic;

namespace StudEng.Models
{
    public partial class Modulle
    {

        public int? IdModulle { get; set; }
        public string? Listening { get; set; } = null!;
        public string? Reading { get; set; } = null!;
        public string? Speaking { get; set; } = null!;
        public string? Writing { get; set; } = null!;
        public int? CompanyyId { get; set; }
        public int? SaleId { get; set; }

    }
}
