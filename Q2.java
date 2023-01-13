import java.util.Scanner;

public class Q2
{
    public static Scanner leia = new Scanner(System.in);
    public static void main(String args[])
    {
        int número, acumulador;
        System.out.print("Digite um número maior do que 0: ");
        número = leia.nextInt();
        if (número > 0)
        {
           acumulador = 0;
           System.out.print("A soma dos números entre zero e este número é ");
           for (int contador = 0; contador < número; contador ++)
           {
                acumulador = acumulador + contador;
           }
           System.out.printf("%d.\n", acumulador);
        }
        else
        {
            System.out.println("Você deve digitar um número maior do que 0.");
        }
    }
}