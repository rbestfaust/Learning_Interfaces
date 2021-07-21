using System;
using System.Collections.Generic;
using System.Text;

namespace Myrocket
{
    class Audi_dvijok:IDvijok
    {

        public int Speed { get; }

        public string Name { get; }

        public int Weight { get; set; }

        public Audi_dvijok()
        {
            Speed = 330;
            Name = "AudiSuper";
            Weight = 700;
        }
    }
}
