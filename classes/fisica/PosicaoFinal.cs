using System;

    /*esse é o calculo para posição final em física
        s = s0 + v0*t + (gt^2)/2
        onde:
        • s = posição final;
        • s0 = posição inicial;
        • v0 = velocidade inicial;
        • t = tempo percorrido;
        • g = aceleração gravitacional (Gterra = ~9,8m/s²).
    */
namespace first_cs.classes.fisica
{
    public class PosicaoFinal
    {
        const double g = 9.8f;
        public void PosFinal(){
            Console.WriteLine("Digite a Posição Inicial: ");
            double s0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a Velociade Inicial: ");
            double v0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o Tempo: ");
            double t = Convert.ToDouble(Console.ReadLine());
            double s = s0 + v0*t + (g*(t*t))/2;
            Console.WriteLine(s);
        }
    }
}