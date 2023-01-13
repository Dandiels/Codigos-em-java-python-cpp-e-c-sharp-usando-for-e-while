using System;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            float número;
            Console.Write("Digite um número: ");
            número = float.Parse(Console.ReadLine());
            Console.WriteLine("A tabuada de multiplicação de 1 à 10 deste número é:");
            for (byte multiplicador = 1; multiplicador <= 10; multiplicador ++)
            {
                Console.WriteLine("{0} x {1} = {2}.", número, multiplicador, número * multiplicador);
            }
        }
    }
}