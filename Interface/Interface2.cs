using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IDog // didnt necessarily need to create this but did just to show that you can use didnt interfaces
    {
        public string Breed { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
    }
}
