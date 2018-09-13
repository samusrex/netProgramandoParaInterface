using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Classificacao
{
    class Peixe : Animal
    {
        public override void Locomover()
        {
            Console.WriteLine("Swimmin' like a fish");
        }

        public override void Comer()
        {
            Console.WriteLine("Eatin' like a fish");
        }

        public override void Dormir()
        {
            Console.WriteLine("Sleep' like a fish");
        }

        public override void Morrer()
        {
            Console.WriteLine("Die' like a fish");
        }

        public override void Reproduzir()
        {
            Console.WriteLine("Reproduce' like a fish");
        }
    }
}
