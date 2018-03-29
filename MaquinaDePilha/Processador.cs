using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDePilha
{
    class Processador
    {
        public Dictionary<string,int> labels =  new Dictionary<string, int>();
        public Memoria memoria = new Memoria();
        public Pilha pilha = new Pilha();

        public int processar(int index, Instrucoes instrucao)
        {
            return 34;
        }
    }
}
