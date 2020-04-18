using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Pojazdy
{
    class Samochod : Pojazd 
    {
        public void Uruchom()
        {
            Console.WriteLine("Silnik start");
        }

        public void Zatankuj()
        {
            Console.WriteLine("Zalej benzyna/ON/LPG");
        }

        public void Zatrzymaj()
        {
            Console.WriteLine("Silnik stop");
        }
    }
}
