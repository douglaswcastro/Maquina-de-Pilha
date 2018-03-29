using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDePilha.instrucoesPilha
{
    class Read : Instrucoes
    {
        Pilha pilha;

        public Read(Pilha pilha)
        {
            this.pilha = pilha;
        }

        public override void executar()
        {
            string valor = Console.ReadLine();
            if(valor == "true")
            {
                Booleano ex = new Booleano(true);
                pilha.push(ex);
            }
            else if(valor == "false")
            {
                Booleano ex = new Booleano(false);
                pilha.push(ex);
            }
            else
            {
                Inteiro ex = new Inteiro(int.Parse(valor));
                pilha.push(ex);
            }

        }
    }
}
