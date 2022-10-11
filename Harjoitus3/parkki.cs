using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3
{
    internal class parkki
    {
        public parkki(TimeSpan paika, double phinta)
        {
            pAika = paika;
            pHinta = phinta;
        }

        public TimeSpan pAika { get; set; }
        public double pHinta { get; set; }


    }
}
