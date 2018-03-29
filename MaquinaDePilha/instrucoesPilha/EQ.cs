using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDePilha.instrucoesPilha
{
    class EQ : Instrucoes
    {
        Pilha pilha;

        public EQ(Pilha pilha)
        {
            this.pilha = pilha;
        }

        public override void executar()
        {
            int num1 = int.Parse(pilha.inspect().ToString());
            pilha.pop();
            int num2 = int.Parse(pilha.inspect().ToString());
            pilha.pop();
            if(num1 == num2)
            {
                tipo result = new Booleano(true);
                pilha.push(result);
            }
            else
            {
                tipo result = new Booleano(false);
                pilha.push(result);
            }           
        }
    }
}
