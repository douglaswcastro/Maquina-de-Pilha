using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDePilha
{
    class Booleano : tipo
    {
        private Boolean numero;

        public Booleano(Boolean valor)
        {
            this.numero = valor;
        }

        public override string ToString()
        {
            return numero.ToString();
        }
    }
}
