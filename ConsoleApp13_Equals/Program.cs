using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            //string m1 = "Warszawa";
            //String m2 = new string("Warszawa".ToArray());
            //Console.WriteLine(m1.Equals(m2));

            Auto auto1 = new Auto("Toyota", 1995);
            Auto auto2 = new Auto("Toyota", 1995);
            Console.WriteLine(auto1.Equals(auto2));

            Console.ReadKey();
        }
    }

    class Auto
    {
        public string Marka { get; set; }
        public int Rocznik { get; set; }

        public Auto(string Marka, int Rocznik)
        {
            this.Marka = Marka;
            this.Rocznik = Rocznik;
        }

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

        public bool Equals(Auto auto)
        {
            return auto.Marka == this.Marka && auto.Rocznik==this.Rocznik;
        }
    }
}
