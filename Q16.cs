using System;

namespace Q16
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] número = new float[20];
            byte vezes = 1;
            byte[] quantidade = {0, 0, 0};
            for (int i = 0; i < número.Length; i ++, vezes ++)
            {
                Console.Write("Digite o {0}° número: ", vezes);
                número[i] = float.Parse(Console.ReadLine());
                if (número[i] >= 0 & número[i] <= 100)
                {
                    quantidade[0] ++;
                }
                else if (número[i] >= 101 & número[i] <= 200)
                {
                    quantidade[1] ++;
                }
                else if (número[i] > 200)
                {
                    quantidade[2] ++;
                }
            }
            if (quantidade[0] + quantidade[1] + quantidade[2] == 19)
            {
                Console.WriteLine("Entre 0 e 100: {0}, entre 101 e 200: {1} e maiores do que 200: {2}.", quantidade[0], quantidade[1], quantidade[2]);
                Console.WriteLine("O número restante é menor do que 0.");
            }
            else if (quantidade[0] + quantidade[1] + quantidade[2] < 19)
            {
                Console.WriteLine("Entre 0 e 100: {0}, entre 101 e 200: {1} e maiores do que 200: {2}.", quantidade[0], quantidade[1], quantidade[2]);
                Console.WriteLine("Os números restantes são menores do que 0.");
            }
            else
            {
                Console.WriteLine("Entre 0 e 100: {0}, entre 101 e 200: {1} e maiores do que 200: {2}.", quantidade[0], quantidade[1], quantidade[2]);
            }
        }
    }
}