using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDePilha.instrucoesPilha
{
    class Load : Instrucoes
    {
        Memoria memoria;
        Pilha pilha;
        string parametro;

        public Load(Memoria memoria, Pilha pilha, string parametro)
        {
            this.memoria = memoria;
            this.pilha = pilha;
            this.parametro = parametro;
        }

        public override void executar()
        {
            pilha.push(memoria.load(parametro));
        }
    }
}
            
