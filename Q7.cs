using System;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] número = new float[10]; 
            float soma = 0;
            byte vezes = 1;
            for (byte i = 0; i < número.Length; i ++, vezes ++)
            {
                Console.Write("Digite o {0}° número: ", vezes);
                número[i] = float.Parse(Console.ReadLine());
                soma = soma + número[i];
            }
            Console.WriteLine("A soma dos 10 números que você digitou é {0}.", soma);
        }
    }
}