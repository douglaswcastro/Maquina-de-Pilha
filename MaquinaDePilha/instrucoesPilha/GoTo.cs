﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDePilha.instrucoesPilha
{
    class GoTo : Instrucoes
    {
        Pilha pilha;
        Dictionary<string, int> labels;
        string label;
        public int index;

        public GoTo(Dictionary<string,int> labels, string label,Pilha pilha)
        {
            this.labels = labels;
            this.label = label;
            this.pilha = pilha;
        }

        public override void executar()
        {
            
        }
        public void executar(int i)
        {
            if (pilha.inspect().ToString() == "True")
            {
                index = labels[label];
            }
            else
            {
                index = i;
            }
        }
    }
}
