using System;

namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] idade = new ushort[20];
            ushort soma = 0;
            byte vezes = 1, média;
            for (byte i = 0; i < idade.Length; i ++, vezes ++)
            {
                Console.Write("Digite a {0}ª idade: ", vezes);
                idade[i] = Convert.ToUInt16(ushort.Parse(Console.ReadLine()));
                soma = Convert.ToUInt16(soma + idade[i]);
            }
            média = Convert.ToByte(soma / 20);
            Console.WriteLine("A média das 20 idades que você digitou é {0} anos.", média);
        }
    }
}