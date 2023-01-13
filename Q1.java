import java.util.Scanner;

public class Q1
{
    public static Scanner leia = new Scanner(System.in);
    public static void main(String args[])
    {
        int número, ordem;
        System.out.print("Digite um número maior do que 0: ");
        número = leia.nextInt();
        if (número > 0)
        {
            System.out.print("Digite 1 para ordem crescente ou 2 para ordem decrescente: ");
            ordem = leia.nextInt();
            if (ordem == 1)
            {
                número --;
                System.out.print("A ordem crescente do zero até este número é ");
                for (int listagem = 0; listagem < número; listagem ++)
                {
                    System.out.printf("%d, ", listagem);
                }
                System.out.printf("%d e %d.\n", número, número + 1);
            }
            else if (ordem == 2)
            {
                System.out.print("A ordem decrescente deste número até zero é ");
                for (int listagem = número; listagem > 1; listagem --)
                {
                    System.out.printf("%d, ", listagem);
                }
                System.out.println("1 e 0.");
            }
            else
            {
                System.out.println("Você deve digitar um dos valores pedidos.");
            }
        }
        else
        {
            System.out.println("Você deve digitar um número maior do que 0.");
        }
    }
}