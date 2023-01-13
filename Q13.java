import java.util.Scanner;

public class Q13
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
            if (número[i] > 8)
            {
                quantidade ++;
            }
        }
        switch (quantidade)
        {
            case 0:    
                System.out.println("Dos 20 números que você digitou, nenhum deles é maior do que 8.");
                break;
            case 20:
                System.out.println("Dos 20 números que você digitou, todos eles são maiores do que 8.");
                break;
            default:
                System.out.printf("Dos 20 números que você digitou, %d deles são maiores do que 8.\n", quantidade);
                break;
        }
    }
}