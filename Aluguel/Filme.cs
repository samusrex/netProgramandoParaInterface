using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluguel
{
    public class Filme : IItem
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int Avaliacao { get; set; }
        public double Preco { get; set; }

    }
}
