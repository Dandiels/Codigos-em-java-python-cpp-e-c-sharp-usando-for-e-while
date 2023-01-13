import java.util.Scanner;

public class Q3
{
    public static Scanner leia = new Scanner(System.in);
    public static void main(String args[])
    {
        int num1, num2, soma;
        System.out.print("Digite um número maior ou igual à 0: ");
        num1 = leia.nextInt();
        if (num1 < 0)
        {
            System.out.println("Você deve digitar um número maior ou igual à 0.");
        }
        else
        {
            System.out.print("Digite outro número também maior ou igual à 0: ");
            num2 = leia.nextInt();
            if (num2 < 0)
            {
                System.out.println("Você deve digitar um número maior ou igual à 0.");
            }
            else
            {
                soma = 0;
                for (int contador = 0; contador < num2; contador ++)
                {
                    soma = soma + num1;
                }
                System.out.printf("O resultado da multiplicação entre estes dois números, através de somas repetidas, é %d.\n", soma);
            }
        }
    }
}