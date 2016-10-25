using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Konto
    {
        public double saldoPoczatkowe;
        public double saldoKoncowe;
        public string PrzelewMiedzyKontami(double saldoPoczatkowe, double ile)
    {
        saldoKoncowe=ile-saldoPoczatkowe;
        return "Przelano! zostalo ci: "+ saldoKoncowe;
    }
        public double Wplata(double ile)
        {
            saldoKoncowe += ile;
            return saldoKoncowe;
        }
        public double Wyplata(double ile)
        {
            saldoKoncowe -= ile;
            return saldoKoncowe;
        }
         public Konto() //Tworzenie konstruktora 
        {
            saldoPoczatkowe = 100;
        }
    }
}
