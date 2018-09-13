using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluguel
{
    public class Produto:IItem
    {
        public double Preco { get; set; }
        public string Descricao { get; set; }

    }
}
