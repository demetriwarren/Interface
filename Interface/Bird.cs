using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Bird :IPet
    {
        public string Color { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty ;
        public bool CanFly {  get; set; }

        public string Speak()
        {
            return "Chirp";
        }
    }
}
