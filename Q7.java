import java.util.Scanner;
import java.text.DecimalFormat;

public class Q7
{
    public static Scanner leia = new Scanner(System.in);
    public static void main(String args[])
    {
        float número[] = new float[10], soma = 0;
        int vezes = 1;
        String somaf;
        for (int i = 0; i < número.length; i ++, vezes ++)
        {
            System.out.printf("Digite o %d° número: ", vezes);
            número[i] = leia.nextFloat();
            soma = soma + número[i];
        }
        somaf = new DecimalFormat("#.#").format(soma);
        System.out.printf("A soma dos 10 números que você digitou é %s.\n", somaf);
    }
}