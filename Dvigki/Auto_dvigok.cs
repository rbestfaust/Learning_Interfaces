using System;
using System.Collections.Generic;
using System.Text;

namespace Myrocket
{
    class Auto_dvigok : IDvijok
    {
        public int Speed { get; }

        public string Name { get; }

        public int Weight { get; set; }

        public Auto_dvigok()
        {
            Speed = 250;
            Name = "BMW_15_12";
            Weight = 850;
        }
    }
}
