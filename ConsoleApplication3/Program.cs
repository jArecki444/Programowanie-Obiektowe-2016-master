using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Tomka = new Car();
            Car car2 = new Car(3.5, "Ford"); //zad6
            Car car3 = Car.Create(); //zad10


        }
    }
}
