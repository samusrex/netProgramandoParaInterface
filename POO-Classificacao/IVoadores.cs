using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Classificacao
{
    interface IVoadores
    {
        string Obter_cor_das_penas();
        void Configurar_cor_das_penas(string value);
        void Voar();
    }
}
