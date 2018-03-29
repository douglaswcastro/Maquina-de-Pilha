using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDePilha.instrucoesPilha
{
    class Add : Instrucoes
    {
        Pilha pilha;

        public Add(Pilha pilha)
        {
            this.pilha = pilha;
        }

        public override void executar()
        {
            int num1 = int.Parse(pilha.inspect().ToString());
            pilha.pop();
            int num2 = int.Parse(pilha.inspect().ToString());
            pilha.pop();
            Inteiro in1 = new Inteiro(num1 + num2);
            pilha.push(in1);
        }
    }
}
