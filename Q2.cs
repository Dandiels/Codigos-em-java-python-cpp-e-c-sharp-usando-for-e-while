using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            short número;
            uint acumulador;
            string acumuladorf;
            Console.Write("Digite um número maior do que 0: ");
            número = short.Parse(Console.ReadLine());
            if (número > 0)
            {
                acumulador = 0;
                Console.Write("A soma dos números entre zero e este número é ");
                for (short contador = 0; contador < número; contador ++)
                {
                    acumulador = Convert.ToUInt32(acumulador + contador);
                }
                acumuladorf = string.Format("{0:#,#.######}", acumulador);
                Console.WriteLine("{0}.", acumuladorf);
            }
            else
            {
                Console.WriteLine("Você deve digitar um número maior do que 0.");
            }
        }
    }
}