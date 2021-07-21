using System;
using System.Collections.Generic;
using System.Text;

namespace Myrocket
{
    class Moto_dvigok : IDvijok
    {
        public int Speed { get; }

        public string Name { get ;  }

        public int Weight { get ; set; }

        public Moto_dvigok()
        {
            Weight = 35;
            Name = "Ural_155";
            Speed = 80;
        }
    }
}
