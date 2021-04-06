using System;
namespace first_cs.classes.cnumerico
{
    public class Erro
    {
        private double a;
        public void CalcularErroAbs (){
            Console.WriteLine("Digite o Valor Verdadeiro");
            a = Convert.ToDouble(Console.ReadLine());
            int aI = Convert.ToInt32(a);
            Console.WriteLine("***********************************");
            double erroAbs = Math.Sqrt(Math.Pow((a-aI), 2));
            Console.WriteLine("Erro Absoluto de {0} = {1}", a, erroAbs);
        }

        public void CalcularErroRel (){
            Console.WriteLine("Digite o Valor Verdadeiro");
            a = Convert.ToDouble(Console.ReadLine());
            int aI = Convert.ToInt32(a);
            Console.WriteLine("***********************************");
            double modA = Math.Sqrt(Math.Pow(a, 2));
            double erroAbs = Math.Sqrt(Math.Pow((a-aI), 2));
            double erroRel = erroAbs/modA;
            Console.WriteLine("Erro Relativo de {0} = {1}", a, erroRel);
        }
    }
}