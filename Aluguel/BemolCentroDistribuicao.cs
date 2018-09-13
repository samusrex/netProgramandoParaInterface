using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluguel
{
    public class BemolCentroDistribuicao : IEstoque
    {
        public int Conte(IItem item)
        {
            return new int();
        }

        public void Retire(IItem i)
        {
            Console.WriteLine("Produto Retirado {0}", i);
        }

        public void Retorne(IItem i)
        {
            Console.WriteLine("Produto Retornou ao Estoque {0}",i);
        }
    }
}
