using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaquinaDePilha.instrucoesPilha;

namespace MaquinaDePilha
{
    class Program
    {
        static void Main(string[] args)
        {
            //Memoria memoria = new Memoria();
            //Pilha pilha = new Pilha();
            Processador processador = new Processador();
            tipo num1 = new Inteiro(3);
            tipo num2 = new Inteiro(5);
            tipo num3 = new Inteiro(8);


            //Instrucoes instruc = new Push(processador.pilha,num1);
            //instruc.executar();

            //Instrucoes instruc5 = new Store(processador.memoria, processador.pilha, "opa");
            //instruc5.executar();

            //Instrucoes instruc4 = new Pop(processador.pilha);
            //instruc4.executar();

           string[] programa = System.IO.File.ReadAllLines(@"C:/Users/dougl/Desktop/Teste.txt");
            for (int i = 0; i < programa.Length; i++)
            {
                string[] linha = programa[i].Split(' ');
                if(linha[0] == "Label")
                {
                    Instrucoes intruc3 = new Label(processador.pilha, linha[1], i, processador.labels);
                    intruc3.executar();
                }
            }
                for (int i = 0; i < programa.Length;i++)
            {
                string[] linha = programa[i].Split(' ');
                if(linha.Length == 2)
                {
                    switch (linha[0])
                    {
                        case "Push":
                            if (linha[1] == "true")
                            {
                                tipo parametro = new Booleano(true);
                                Instrucoes intruc = new Push(processador.pilha, parametro);
                                intruc.executar();
                            }
                            else if(linha[1] == "false")
                            {
                                tipo parametro = new Booleano(false);
                                Instrucoes intruc1 = new Push(processador.pilha, parametro);
                                intruc1.executar();
                            }
                            else
                            {
                                tipo parametro = new Inteiro(int.Parse(linha[1]));
                                Instrucoes intruc2 = new Push(processador.pilha, parametro);
                                intruc2.executar();
                            }
                            break;

                        case "Load":
                            Instrucoes intruc4 = new Load(processador.memoria, processador.pilha, linha[1]);
                            intruc4.executar();
                            break;

                        case "Store":
                            Instrucoes intruc5 = new Store(processador.memoria, processador.pilha, linha[1]);
                            intruc5.executar();
                            break;

                        case "GoTo":
                            GoTo intruc6 = new GoTo(processador.labels, linha[1], processador.pilha);
                            intruc6.executar(i);
                            i=intruc6.index;      
                            break;

                        case "GoTof":
                            GoTof intruc7 = new GoTof(processador.labels, linha[1], processador.pilha);
                            intruc7.executar(i);
                            i = intruc7.index;
                            break;
                    } 
                }
                else if(linha.Length == 1)
                {
                    switch (linha[0])
                    {
                        case "Pop":
                            Instrucoes intruc = new Pop(processador.pilha);
                            intruc.executar();
                            break;

                        case "Add":
                            Instrucoes intruc2 = new Add(processador.pilha);
                            intruc2.executar();
                            break;

                        case "Sub":
                            Instrucoes intruc3 = new Sub(processador.pilha);
                            intruc3.executar();
                            break;

                        case "EQ":
                            Instrucoes intruc4 = new EQ(processador.pilha);
                            intruc4.executar();
                            break;

                        case "GE":
                            Instrucoes intruc5 = new GE(processador.pilha);
                            intruc5.executar();
                            break;

                        case "GT":
                            Instrucoes intruc6 = new GT(processador.pilha);
                            intruc6.executar();
                            break;

                        case "LE":
                            Instrucoes intruc7 = new LE(processador.pilha);
                            intruc7.executar();
                            break;

                        case "LT":
                            Instrucoes intruc8 = new LT(processador.pilha);
                            intruc8.executar();
                            break;

                        case "NE":
                            Instrucoes intruc9 = new NE(processador.pilha);
                            intruc9.executar();
                            break;

                        case "Print":
                            Instrucoes intruc10 = new Print(processador.pilha);
                            intruc10.executar();
                            break;

                        case "Read":
                            Instrucoes intruc11 = new Read(processador.pilha);
                            intruc11.executar();
                            break;

                        case "end":
                            i = programa.Length;
                            break;



                    }
                }
            }

            //Instrucoes instruc3 = new Push(processador.pilha, num2);
            //instruc3.executar();

            //Instrucoes instruc6 = new Load(processador.memoria, processador.pilha, "opa");
            //instruc6.executar();

            //Instrucoes instruc7 = new Add(processador.pilha);
            //instruc7.executar();

            //Instrucoes instruc9 = new Push(processador.pilha, num3);
            //instruc9.executar();

            //Instrucoes instruc8 = new EQ(processador.pilha);
            //instruc8.executar();

            //Instrucoes instruc2 = new Print(processador.pilha);
            //instruc2.executar();

            Console.ReadKey();

        }
    }
}
