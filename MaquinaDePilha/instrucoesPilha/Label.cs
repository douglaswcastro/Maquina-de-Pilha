using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDePilha.instrucoesPilha
{
    class Label : Instrucoes
    {
        Pilha pilha;
        string parametro;
        int index;
        Dictionary<string, int> labels;

        public Label(Pilha pilha, string parametro, int index, Dictionary<string,int> labels)
        {
            this.pilha = pilha;
            this.parametro = parametro;
            this.index = index;
            this.labels = labels; 
        }

        public override void executar()
        {
            labels.Add(parametro, index);
        }
    }
}
