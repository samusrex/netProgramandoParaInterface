using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluguel
{
    public class Locadora : IEstoque
    {
        List<Filme> Filmes = new List<Filme>();

        public void Retire(IItem i)
        {
            Filme retorno = (Filme)i;
            Filme encontrado = Filmes.Find(c => c.Nome.Equals(retorno.Nome));

            if (retorno.GetQtde() != 0)
            {
                retorno.SetQtde(retorno.GetQtde() - 1);
            }


        }

        public int Conte(IItem item)
        {
            Filme retorno = (Filme)item;
            Filme encontrado = Filmes.Find(c => c.Nome.Equals(retorno.Nome));
            return retorno.GetQtde();
        }

        public void Retorne(IItem i, int qtde)
        {
            Filme retorno = (Filme)i;
            Filme encontrado = Filmes.Find(c => c.Nome.Equals(retorno.Nome));
            retorno.SetQtde(retorno.GetQtde() + qtde);
            Console.WriteLine("Adicionado ao Produto {0} a quantidade de {1}", retorno.Nome, qtde);

        }

        public void Adicione(IItem i)
        {
            Filme novoFilme = (Filme)i;
            novoFilme.SetQtde(novoFilme.GetQtde()+1);
            this.Filmes.Add(novoFilme);
        }

        public void Exclua(IItem i)
        {
            this.Filmes.Remove((Filme)i);
        }
    }
}
