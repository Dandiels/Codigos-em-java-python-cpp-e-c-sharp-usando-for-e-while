using System;

namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];
            ushort[] idade = new ushort[10];
            byte vezes = 1, i, n = 0;
            for (i = 0; i < nome.Length; i ++, vezes ++)
            {
                Console.Write("Digite o nome da {0}ª pessoa: ", vezes);
                nome[i] = Console.ReadLine();
                Console.Write("Digite a idade dela: ");
                idade[i] = Convert.ToUInt16(ushort.Parse(Console.ReadLine()));
            }
            i = 0;
            while (i <= idade.Length - 1)
            {
                if (idade[i] <= idade[n])
                {
                    if (n == idade.Length - 1)
                    {
                        break;
                    }
                    else
                    {   
                        n ++;
                    }
                }
                else
                {
                    n = 0;
                    i ++;
                }
            }
            Console.WriteLine("Dentre essas pessoas, a pessoa mais nova é {0}.", nome[i]);
        }
    }
}