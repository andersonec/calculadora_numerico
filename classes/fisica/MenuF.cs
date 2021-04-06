using System;
namespace first_cs.classes.fisica
{
    public class MenuF
    {
        public void ChamaMenuF(){
            string op;
            do{
                Console.WriteLine("Digite o código da Operação.");
                Console.WriteLine("01 - Posição Final \n" +
                                  "99 - Encerrar programa.");
                op = Console.ReadLine();
                switch(op){
                    case "01":
                        PosicaoFinal pos = new PosicaoFinal();
                        Console.WriteLine("Vamos calcular a posição final.");
                        pos.PosFinal();
                        break;
                }
            }while(op != "99");
        }
    }
}