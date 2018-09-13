using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluguel
{
    public class BemolCentroDistribuicao : IEstoque
    {
        List<Produto> Produtos = new List<Produto>();

        public void Retire(IItem i)
        {
            Produto retorno = (Produto)i;
            Produto encontrado = Produtos.Find(c => c.Descricao.Equals(retorno.Descricao));

            if (retorno.GetQtde() != 0)
            {
                retorno.SetQtde(retorno.GetQtde() - 1);
            }


        }

        public int Conte(IItem item)
        {
            Produto retorno = (Produto)item;
            Produto encontrado = Produtos.Find(c => c.Descricao.Equals(retorno.Descricao));
            return retorno.GetQtde();
        }

        public void Retorne(IItem i, int qtde)
        {
            Produto retorno = (Produto)i;
            Produto encontrado = Produtos.Find(c => c.Descricao.Equals(retorno.Descricao));
            retorno.SetQtde(retorno.GetQtde() + qtde);
            Console.WriteLine("Adicionado ao Produto {0} a quantidade de {1}", retorno.Descricao, qtde);

        }

        public void Adicione(IItem i)
        {
            Produto novoProduto = (Produto)i;
            novoProduto.SetQtde(novoProduto.GetQtde() + 1);
            this.Produtos.Add(novoProduto);
        }

        public void Exclua(IItem i)
        {
            this.Produtos.Remove((Produto)i);
        }
    }
}
