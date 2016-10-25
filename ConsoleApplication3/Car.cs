using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;

        public Car() //Tworzenie konstruktora zad4
        {
            pojemnoscSilnika = 4.8;
            marka = "Skoda";
        }
        public Car(double pojemnoscSilnika, string marka)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka; //konstruktor z parametrami
        }
        static public Car Create()
        {
            return new Car();
        }
        static int iloscKol;
        static Car()
        {
            iloscKol = 4;
        }
        ~Car() //Destruktor
        {
            Console.WriteLine("Zwalniam pamiec!");
            Console.WriteLine(this.marka); //Zazwyczaj tego nie uzywamy
            Console.ReadKey();
        }
    }
}
