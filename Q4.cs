using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            byte vezes = 1;
            for (byte contador = 0; contador < 20; contador ++, vezes ++)
            {
                Console.WriteLine("{0}ª Vez: Eu gosto de estudar Algoritmos!", vezes);
            }
        }
    }
}