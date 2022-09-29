using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_List
{
    internal class Datuak
    {
        public string Izena { get; set; }
        public Datuak(string izena)
        { this.Izena = izena; }

        public static String DatuenZerrenda(List<Datuak> datulista)
        {
            string mezua = "";
            foreach (Datuak datua in datulista)
            {
                mezua +=datua.Izena + " ";
            }
            return mezua;
        }
    }
}
