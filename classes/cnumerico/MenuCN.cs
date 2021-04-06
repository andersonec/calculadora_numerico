using System;
namespace first_cs.classes.cnumerico
{
    public class MenuCN
    {
        public void ChamaMenuCN(){
            string op;
            do{
                Console.WriteLine("Digite o código da Operação.");
                Console.WriteLine("01 - Erro Absoluto \n" +
                                  "02 - Erro Relativo \n" +
                                  "99 - Encerrar programa.");
                op = Console.ReadLine();
                switch(op){
                    case "01":
                        Erro erroA = new Erro();
                        Console.WriteLine("Vamos calcular o Erro Absoluto.");
                        erroA.CalcularErroAbs();
                        break;
                    case "02":
                        Erro erroR = new Erro();
                        Console.WriteLine("Vamos calcular o Erro Relativo.");
                        erroR.CalcularErroRel();
                        break;
                }
            }while(op != "99");
        }
        
    }
}