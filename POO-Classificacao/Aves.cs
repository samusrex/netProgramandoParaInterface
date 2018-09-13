using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Classificacao
{
    public class Aves : Animal, IVoadores
    {

        private string Cor_das_penas { get; set; }
        public override void Comer()
        {
            Console.WriteLine("Eating' like a birdie");
        }

        public void Configurar_cor_das_penas(string value)
        {
            this.Cor_das_penas = value;
        }

        public override void Dormir()
        {
            Console.WriteLine("Sleep' like a birdie");
        }

        public override void Locomover()
        {
            Console.WriteLine("Flyin' like a birdie");
        }

        public override void Morrer()
        {
            Console.WriteLine("Diw' like a birdie");
        }

        public string Obter_cor_das_penas()
        {
            return this.Cor_das_penas;
        }

        public override void Reproduzir()
        {
            Console.WriteLine("Reproduce like a birdie");
        }

        public void Voar()
        {
            Console.WriteLine("Fly away");
        }
    }
}
