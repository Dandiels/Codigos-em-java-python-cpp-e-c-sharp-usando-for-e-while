using System;

namespace Q15
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] número = new float[20];
            byte vezes = 1, quantidade = 0;
            for (byte i = 0; i < número.Length; i ++, vezes ++)
            {
                Console.Write("Digite o {0}° número: ", vezes);
                número[i] = float.Parse(Console.ReadLine());
                if (número[i] >= 0 & número[i] <= 100)
                {
                    quantidade ++;
                }
            }
            switch (quantidade)
            {
                case 0:
                    Console.WriteLine("Dos 20 números que você digitou, nenhum deles está entre 0 e 100.");
                    break;
                case 20:
                    Console.WriteLine("Dos 20 números que você digitou, todos eles estão entre 0 e 100.");
                    break;
                default:
                    Console.WriteLine("Dos 20 números que você digitou, {0} deles estão entre 0 e 100.", quantidade);
                    break;
            }
        }
    }
}