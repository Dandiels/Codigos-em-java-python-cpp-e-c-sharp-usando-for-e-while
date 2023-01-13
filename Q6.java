import java.util.Scanner;

public class Q6
{
    public static Scanner leia = new Scanner(System.in);
    public static void main(String args[])
    {
        String nome;
        int número_de_vezes, vezes = 1;
        System.out.print("Digite o seu nome: ");
        nome = leia.nextLine();
        System.out.print("Digite a quantidade de vezes que deseja que o seu nome apareça na tela: ");
        número_de_vezes = leia.nextInt();
        for (int contador = 0; contador < número_de_vezes; contador ++, vezes ++)
        {
            System.out.printf("%dª Vez: %s.\n", vezes, nome);
        }
    }
}