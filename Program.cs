using System;
using first_cs.classes.fisica;
using first_cs.classes.cnumerico;

namespace first_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            do{
                Console.WriteLine("Digite o código da Operação.");
                Console.WriteLine("01 - Fisica \n" +
                                  "02 - Calculo Numérico \n" +
                                  "99 - Encerrar programa.");
                op = Console.ReadLine();
                switch(op){
                    case "01":
                        MenuF menuFisica = new MenuF();
                        menuFisica.ChamaMenuF();
                        break;
                    case "02":
                        MenuCN menuNumerico = new MenuCN();
                        menuNumerico.ChamaMenuCN();
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida.");
                        break;
                }
            }while(op != "99");
            
        }
    }
}
