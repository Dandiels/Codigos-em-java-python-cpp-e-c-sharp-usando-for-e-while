import java.util.Scanner;

public class Q15
{
    public static Scanner leia = new Scanner(System.in);
    public static void main(String args[])
    {
        float número[] = new float[20];
        int vezes = 1, quantidade = 0;
        for (int i = 0; i < número.length; i ++, vezes ++)
        {
            System.out.printf("Digite o %d° número: ", vezes);
            número[i] = leia.nextFloat();
            if (número[i] >= 0 & número[i] <= 100)
            {
                quantidade ++;
            }
        }
        switch (quantidade)
        {
            case 0:    
                System.out.println("Dos 20 números que você digitou, nenhum deles está entre 0 e 100.");
                break;
            case 20:
                System.out.println("Dos 20 números que você digitou, todos eles estão entre 0 e 100.");
                break;
            default:
                System.out.printf("Dos 20 números que você digitou, %d deles estão entre 0 e 100.\n", quantidade);
                break;
        }
    }
}
