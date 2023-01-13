import java.util.Scanner;

public class Q4
{
    public static Scanner leia = new Scanner(System.in);
    public static void main(String args[])
    {
        int vezes = 1;
        for (int contador = 0; contador < 20; contador ++, vezes ++)
        {
            System.out.printf("%dª Vez: Eu gosto de estudar Algoritmos!\n", vezes);
        }
    }
}