using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Dog : IPet, IDog
    {
        public string Breed { get; set; } = string.Empty;
        public int Age { get; set; }
        public int Weight { get; set; }
        public string EyeColor { get; set; } = string.Empty ;
        
        
        public string Speak() {
            return "Woof";
        }

    }
}
