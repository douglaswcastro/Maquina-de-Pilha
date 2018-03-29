using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDePilha.instrucoesPilha
{
    class Store : Instrucoes
    {
        Memoria memoria;
        Pilha pilha;
        string parametro;

        public Store(Memoria memoria, Pilha pilha, string parametro)
        {
            this.memoria = memoria;
            this.pilha = pilha;
            this.parametro = parametro;
        }

        public override void executar()
        {
            memoria.store(this.parametro, this.pilha.inspect());
        }
    }
}
