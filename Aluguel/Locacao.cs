using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluguel
{
    public class Locacao : ICompra
    {

        IEstoque estoque;
        List<Filme> meusFilmes = new List<Filme>();
        double Total = 0;


        public Locacao(IEstoque est)
        {
            this.estoque = est;
        }

        public void AdicionaItens(IItem i)
        {
            Filme filmeAdiciona = (Filme)i;

            if (EstaDisponivel(i))
            {
                meusFilmes.Add((Filme)i);
            }
            else
            {
                Console.WriteLine("Filme Indisponível");

            }


        }


        public double Totalizar()
        {

            foreach (var item in meusFilmes)
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
            return this.meusFilmes.ToList<IItem>();
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
            meusFilmes.Remove((Filme)i);
        }


    }
}
