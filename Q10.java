import java.util.Scanner;

public class Q10
{
    public static Scanner leia = new Scanner(System.in);
    public static void main(String args[])
    {
        int idade[] = new int[20], vezes = 1, pessoas = 0;
        for (int i = 0; i < idade.length; i ++, vezes ++)
        {
            System.out.printf("Digite a %dª idade: ", vezes);
            idade[i] = leia.nextInt();
            if (idade[i] >= 18)
            {
                pessoas ++;
            }
        }
        switch (pessoas)
        {
            case 0:    
                System.out.println("Das 20 idades que você digitou, nenhuma delas são de pessoas maiores de idade.");
                break;
            case 20:
                System.out.println("Das 20 idades que você digitou, todas elas são de pessoas maiores de idade.");
                break;
            default:
                System.out.printf("Das 20 idades que você digitou, %d delas são de pessoas maiores de idade.\n", pessoas);
                break;
        }
    }
}