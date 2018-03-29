using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDePilha
{
    class Pilha
    {
        private Stack<tipo> pilha = new Stack<tipo>();

        public void push(tipo num)
        {
            pilha.Push(num);
        }
        public tipo pop()
        {
            return pilha.Pop();
        }
        public tipo inspect()
        {
            return pilha.Peek();
        }
    }
}
