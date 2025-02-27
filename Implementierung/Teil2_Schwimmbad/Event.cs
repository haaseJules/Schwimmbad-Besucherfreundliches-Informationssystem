using System;
using System.Collections.Generic;

namespace Teil2_Schwimmbad
{
    public partial class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; } = null!;
        public TimeSpan Uhrzeit { get; set; }
        public string? Kursleiter { get; set; }
    }
}
