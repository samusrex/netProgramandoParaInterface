using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluguel
{
    public class CompraLoja : ICompra
    {


        IEstoque estoque;
        List<Produto> Produtos = new List<Produto>();
        double Total = 0;


        public CompraLoja(IEstoque est)
        {
            this.estoque = est;
        }

        public void AdicionaItens(IItem i)
        {
            Produto ProdutoAdiciona = (Produto)i;

            if (EstaDisponivel(i))
            {
                Produtos.Add(ProdutoAdiciona);
            }
            else
            {
                Console.WriteLine("Filme Indisponível");

            }


        }


        public double Totalizar()
        {

            foreach (var item in Produtos)
            {

                Total += item.Preco;

            }

            return this.Total;
        }

        public bool EstaDisponivel(IItem consulta)
        {
            if (this.estoque.Conte(consulta) > 0)
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        public IList<IItem> MinhasCompras()
        {
            return this.Produtos.ToList<IItem>();
        }

        public void RealizaPagamento(double valor)
        {
            if (valor >= Total)
            {
                Console.WriteLine("O total de sua Compra foi de R${0}. E o pagamento foi de R${1} . Seu Troco é de {2} Real", Total, valor, (valor - Total));
            }
            else
            {

                Console.WriteLine("Pagamento Insuficiente. E o total é de {0} Reais", Total);

            }

        }

        public void RetiraItens(IItem i)
        {
            Produtos.Remove((Produto)i);
        }


    }
}
