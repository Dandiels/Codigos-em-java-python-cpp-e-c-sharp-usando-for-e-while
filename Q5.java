import java.util.Scanner;

public class Q5
{
    public static Scanner leia = new Scanner(System.in);
    public static void main(String args[])
    {
        String nome;
        int vezes = 1;
        System.out.print("Digite o seu nome: ");
        nome = leia.nextLine();
        for (int contador = 0; contador < 10; contador ++, vezes ++)
        {
            System.out.printf("%dª Vez: %s.\n", vezes, nome);
        }
    }
}