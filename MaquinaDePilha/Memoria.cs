using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDePilha
{
    class Memoria
    {
        private Dictionary<string, tipo> tabela = new Dictionary<string, tipo>();

        public void store(string index, tipo valor)
        {
            tabela.Add(index, valor);
        }
        public tipo load(string index)
        {
            return tabela[index];
        }
    }
}
