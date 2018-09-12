using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluguel
{
    public class Locadora : IEstoque
    {
     
       public void Retire(IItem i)
        {
            Console.WriteLine("Filme retirado {0}", new Filme());
        }

        public int Conte(IItem item)
        {
            return new int();
        }

        public void Retorne(IItem i)
        {
            Console.WriteLine("Devolvido {0}", new Filme());
        }
    }
}
