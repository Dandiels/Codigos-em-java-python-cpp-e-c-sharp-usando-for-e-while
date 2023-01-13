using System;

namespace Q17
{
    class Program
    {
        static void Main(string[] args)
        {
            float número, soma = 0;
            byte i = 0;
            string somaf;
            Console.WriteLine("Digite uma sequência de números:");
            while (i >= 0)
            {
                número = float.Parse(Console.ReadLine());
                soma = soma + número;
                if (número < 0)
                {
                    break;
                }
            }
            somaf = string.Format("{0:#,#.######}", soma);
            Console.WriteLine("A soma dos números que você digitou, até o número negativo, é {0}.", somaf);
        }
    }
}