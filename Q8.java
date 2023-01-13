import java.util.Scanner;

public class Q8
{
    public static Scanner leia = new Scanner(System.in);
    public static void main(String args[])
    {
        int idade[] = new int[20], soma = 0, vezes = 1;
        for (int i = 0; i < idade.length; i ++, vezes ++)
        {
            System.out.printf("Digite a %dª idade: ", vezes);
            idade[i] = leia.nextInt();
            soma = soma + idade[i];
        }
        System.out.printf("A soma das 20 idades que você digitou é %d anos.\n", soma);
    }
}