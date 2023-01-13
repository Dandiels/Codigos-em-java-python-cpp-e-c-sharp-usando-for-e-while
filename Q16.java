import java.util.Scanner;

public class Q16
{
    public static Scanner leia = new Scanner(System.in);
    public static void main(String args[])
    {
        float número[] = new float[20];
        int vezes = 1, quantidade[] = {0, 0, 0};
        for (int i = 0; i < número.length; i ++, vezes ++)
        {
            System.out.printf("Digite o %d° número: ", vezes);
            número[i] = leia.nextFloat();
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
            System.out.printf("Entre 0 e 100: %d, entre 101 e 200: %d e maiores do que 200: %d.\n", quantidade[0], quantidade[1], quantidade[2]);
            System.out.println("O número restante é menor do que 0.");
        }
        else if (quantidade[0] + quantidade[1] + quantidade[2] < 19)
        {
            System.out.printf("Entre 0 e 100: %d, entre 101 e 200: %d e maiores do que 200: %d.\n", quantidade[0], quantidade[1], quantidade[2]);
            System.out.println("Os números restantes são menores do que 0.");
        }
        else
        {
            System.out.printf("Entre 0 e 100: %d, entre 101 e 200: %d e maiores do que 200: %d.\n", quantidade[0], quantidade[1], quantidade[2]);
        }
    }
}
