using System;
using System.Collections.Generic;

namespace Teil2_Schwimmbad
{
    public partial class Kurszeiten
    {
        public int KursId { get; set; }
        public string? Text { get; set; }
        public TimeSpan Uhrzeit { get; set; }
        public string Kursleiter { get; set; } = null!;
    }
}
