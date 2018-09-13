using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluguel
{
    public class Feira : IEstoque
    {
        public IItem Busque(object obj)
        {
            throw new NotImplementedException();
        }

        public void Retire(IItem i)
        {
            throw new NotImplementedException();
        }

        public int Conte(IItem item)
        {
            throw new NotImplementedException();
        }

        public void Retorne(IItem i)
        {
            throw new NotImplementedException();
        }

        public void Retorne(IItem i, int qtde)
        {
            throw new NotImplementedException();
        }

        public void Adicione(IItem i)
        {
            throw new NotImplementedException();
        }

        public void Exclua(IItem i)
        {
            throw new NotImplementedException();
        }
    }
}
