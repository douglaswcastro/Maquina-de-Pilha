using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDePilha.instrucoesPilha
{
    class Push : Instrucoes
    {
       // Memoria memoria;
        Pilha pilha;
        tipo parametro;

        public Push(Pilha pilha, tipo parametro)
        {
            //this.memoria = memoria;
            this.pilha = pilha;
            this.parametro = parametro;
        }
        public override void executar()
        {
            pilha.push(parametro);
        }
    }
}
