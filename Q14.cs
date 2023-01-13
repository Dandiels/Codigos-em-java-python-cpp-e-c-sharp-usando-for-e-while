using System;

namespace Q14
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] número = new ushort[20];
            byte vezes = 1, quantidade = 0;
            for (byte i = 0; i < número.Length; i ++, vezes ++)
            {
                Console.Write("Digite o {0}° número: ", vezes);
                número[i] = Convert.ToUInt16(ushort.Parse(Console.ReadLine()));
                if (número[i] % 2 == 0)
                {
                    quantidade ++;
                }
            }
            switch (quantidade)
            {
                case 0:
                    Console.WriteLine("Dos 20 números que você digitou, nenhum deles é par.");
                    break;
                case 20:
                    Console.WriteLine("Dos 20 números que você digitou, todos eles são pares.");
                    break;
                default:
                    Console.WriteLine("Dos 20 números que você digitou, {0} deles são pares.", quantidade);
                    break;
            }
        }
    }
}