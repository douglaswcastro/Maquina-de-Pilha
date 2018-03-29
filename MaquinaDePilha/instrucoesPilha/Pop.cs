using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDePilha.instrucoesPilha
{
    class Pop : Instrucoes
    {
        Pilha pilha;

    public Pop(Pilha pilha)
    {
        this.pilha = pilha;
    }
    public override void executar()
    {
        pilha.pop();
    }
    }
}
