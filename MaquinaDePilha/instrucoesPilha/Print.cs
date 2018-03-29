using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDePilha.instrucoesPilha
{
    class Print : Instrucoes
    {
        Pilha pilha;

        public Print(Pilha pilha)
        {
            this.pilha = pilha;
        }

        public override void executar()
        { 
            Console.WriteLine(pilha.inspect().ToString());
        }
    }
}
