using System;

namespace Q13
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
                if (número[i] > 8)
                {
                    quantidade ++;
                }
            }
            switch (quantidade)
            {
                case 0:
                    Console.WriteLine("Dos 20 números que você digitou, nenhum deles é maior do que 8.");
                    break;
                case 20:
                    Console.WriteLine("Dos 20 números que você digitou, todos eles são maiores do que 8.");
                    break;
                default:
                    Console.WriteLine("Dos 20 números que você digitou, {0} deles são maiores do que 8.", quantidade);
                    break;
            }
        }
    }
}