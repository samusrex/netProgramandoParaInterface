using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Classificacao
{
    public class Cao : Animal,IMamifero
    {
        public override void Locomover()
        {
            Console.WriteLine("Walkin' like a Dog.");
        }

        public override void Comer()
        {
            Console.WriteLine("Eating' like a Dog.");
        }

        public override void Dormir()
        {
            Console.WriteLine("Sleep' like a Dog.");
        }

        public override void Morrer()
        {
            Console.WriteLine("Die' like a Dog.");
        }

        public override void Reproduzir()
        {
            Console.WriteLine("Reproduce like a Dog.");
        }

        public void Mamar()
        {
            Console.WriteLine("Drink Milk from you Mommy");
        }
    }
}
