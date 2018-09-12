using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluguel
{
    public interface ICompra
    {
        void AdicionaItens(IItem it);
        void RetiraItens(IItem i);
        IList<IItem> MinhasCompras();
        bool EstaDisponivel(IItem consulta);
        void RealizaPagamento(double valor);
        double Efetivar(Cliente cliente);
    }
}
