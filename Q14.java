import java.util.Scanner;

public class Q14
{
    public static Scanner leia = new Scanner(System.in);
    public static void main(String args[])
    {
        int número[] = new int[20], vezes = 1, quantidade = 0;
        for (int i = 0; i < número.length; i ++, vezes ++)
        {
            System.out.printf("Digite o %d° número: ", vezes);
            número[i] = leia.nextInt();
            if (número[i] % 2 == 0)
            {
                quantidade ++;
            }
        }
        switch (quantidade)
        {
            case 0:    
                System.out.println("Dos 20 números que você digitou, nenhum deles é par.");
                break;
            case 20:
                System.out.println("Dos 20 números que você digitou, todos eles são pares.");
                break;
            default:
                System.out.printf("Dos 20 números que você digitou, %d deles são pares.\n", quantidade);
                break;
        }
    }
}