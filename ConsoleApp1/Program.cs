using Aluguel;
using POO_Classificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    class Program
    {
        static void Main(string[] args)
        {

            //    string numeroA;

            //    Console.WriteLine("Digite os numeros, que deseja tirar uma média. Separe por virgulas");
            //    numeroA = Console.ReadLine();


            //    string[] valores = numeroA.Split(',');

            //    var componentes = new List<double>();

            //    foreach (string item in valores)
            //    {
            //        bool isNumero = double.TryParse(item, out double d);
            //        componentes.Add(d);
            //    }

            //    double soma = componentes.Sum();
            //    double media = componentes.Count();

            //    double result = (soma / media);

            //    Console.WriteLine("A media é de {0}", result);

            //Media(0, 10);

            //ICliente cliente = new Cliente();
            //cliente.Aluga(filme);


            //ICliente vip = new ClienteVIP();
            //vip.Aluga(filme);


            //var Vip = new ClienteFactory("vip");
            //Vip.cliente.Aluga(filme);

            //var Normal = new ClienteFactory("normal");
            //Normal.cliente.Aluga(filme);

            Cliente clienteA = new Cliente();
            clienteA.Nome = "TesteA";

            IEstoque Netflix = new Locadora();
            ICompra locacao = new Locacao(Netflix);

            IItem Atividade_Paranormal_1 = new Filme() { Nome = "Atividade Paranormal", Avaliacao = 10, Categoria = "B", Preco = 10 };
            IItem Atividade_Paranormal_2 = new Filme() { Nome = "Atividade Paranormal 2", Avaliacao = 8, Categoria = "B", Preco = 8 };
            IItem Atividade_Paranormal_3 = new Filme() { Nome = "Atividade Paranormal 3", Avaliacao = 10, Categoria = "B", Preco = 10 };
            IItem Atividade_Paranormal_4 = new Filme() { Nome = "Atividade Paranormal 4", Avaliacao = 8, Categoria = "B", Preco = 8 };
            
            locacao.AdicionaItens(Atividade_Paranormal_1);
            locacao.AdicionaItens(Atividade_Paranormal_2);
            locacao.AdicionaItens(Atividade_Paranormal_3);
            locacao.AdicionaItens(Atividade_Paranormal_4);

            locacao.RetiraItens(Atividade_Paranormal_1);


            locacao.Totalizar();
            locacao.RealizaPagamento(19.0);



            Console.WriteLine("-----------------------------------------------------------");

            IEstoque estoqueCD = new BemolCentroDistribuicao();
            ICompra minhaCompra = new CompraLoja(estoqueCD);

            IItem produtoA = new Produto() { Descricao="TV LED 42' LG" , Preco =2800.50 };
            IItem produtoB = new Produto() { Descricao = "TV LED 24' LG", Preco = 1200.50 };

            minhaCompra.AdicionaItens(produtoA);
            minhaCompra.AdicionaItens(produtoB);

            minhaCompra.Totalizar();
            minhaCompra.RealizaPagamento(5000);











            Console.ReadKey();
        }

        static void Media(int inicial, int final)
        {

            int somatorio = 0;
            int contador = 0;
            while (inicial <= final)
            {
                inicial++;
                contador++;

                somatorio += inicial;


            }

            Console.WriteLine("o valor da media é {0}", (somatorio / contador));


        }

        private class SubClasse : Object { }



    }


}
