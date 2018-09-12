using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluguel
{
    public interface IEstoque
    {
        int Conte(IItem item);
        void Retorne(IItem i);
        void Retire(IItem i);
       
       



    }
}
