using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            short num1, num2;
            int soma;
            Console.Write("Digite um número maior ou igual à 0: ");
            num1 = short.Parse(Console.ReadLine());
            if (num1 < 0)
            {
                Console.WriteLine("Você deve digitar um número maior ou igual à 0.");
            }
            else
            {
                Console.Write("Digite outro número também maior ou igual à 0: ");
                num2 = short.Parse(Console.ReadLine());
                if (num2 < 0)
                {
                    Console.WriteLine("Você deve digitar um número maior ou igual à 0.");
                }
                else
                {
                    soma = 0;
                    for (short contador = 0; contador < num2; contador ++)
                    {
                        soma = soma + num1;
                    }
                    if (soma == 0)
                    {
                        Console.WriteLine("O resultado da multiplicação entre estes dois números, através de somas repetidas, é {0}.", soma);
                    }
                    else
                    {
                        string somaf;
                        somaf = string.Format("{0:#,#.######}", soma);
                        Console.WriteLine("O resultado da multiplicação entre estes dois números, através de somas repetidas, é {0}.", somaf);
                    }
                }
            }
        }
    }
}