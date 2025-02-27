using System;
using System.Collections.Generic;

namespace Teil2_Schwimmbad
{
    public partial class Becken
    {
        public int BeckenId { get; set; }
        public string? Name { get; set; }
        public string? Details { get; set; }
        public TimeSpan? Uhrzeit { get; set; }
    }
}
