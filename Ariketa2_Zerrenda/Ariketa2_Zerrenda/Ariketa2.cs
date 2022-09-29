using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa2_Zerrenda
{

    public class Ariketa2
    {
        public string Label { get; set; }
        public double Zenbakia { get; set; }

        public Ariketa2(double zenbakia)
        {
            this.Zenbakia = zenbakia;
        }

        public static double eragiketa(List<Ariketa2> objektuak)
        {
            double emaitza = (objektuak[0].Zenbakia + (objektuak[1].Zenbakia * 2) + (objektuak[2].Zenbakia * 3) + (objektuak[3].Zenbakia * 4)) / 4;

            return emaitza;
        }
    }
}


