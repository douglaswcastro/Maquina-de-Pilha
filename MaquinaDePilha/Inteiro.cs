using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDePilha
{
    class Inteiro : tipo
    {
        public int numero;

        public Inteiro(int valor)
        {
            this.numero = valor;
        }
        public override string ToString()
        {
            return numero.ToString();
        }
    }
}
