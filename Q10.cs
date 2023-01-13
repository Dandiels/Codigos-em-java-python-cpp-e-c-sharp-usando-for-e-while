using System;

namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] idade = new ushort[20];
            byte vezes = 1, pessoas = 0;
            for (byte i = 0; i < idade.Length; i ++, vezes ++)
            {
                Console.Write("Digite a {0}ª idade: ", vezes);
                idade[i] = Convert.ToUInt16(ushort.Parse(Console.ReadLine()));
                if (idade[i] >= 18)
                {
                    pessoas ++;
                }
            }
            switch (pessoas)
            {
                case 0:
                    Console.WriteLine("Das 20 idades que você digitou, nenhuma delas são de pessoas maiores de idade.");
                    break;
                case 20:
                    Console.WriteLine("Das 20 idades que você digitou, todas elas são de pessoas maiores de idade.");
                    break;
                default:
                    Console.WriteLine("Das 20 idades que você digitou, {0} delas são de pessoas maiores de idade.", pessoas);
                    break;
            }
        }
    }
}