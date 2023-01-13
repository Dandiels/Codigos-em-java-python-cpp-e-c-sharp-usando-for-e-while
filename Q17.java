import java.util.Scanner;
import java.text.DecimalFormat;

public class Q17
{
    public static Scanner leia = new Scanner(System.in);
    public static void main(String args[])
    {
        float número, soma = 0;
        int i = 0;
        String somaf;
        System.out.println("Digite uma sequência de números:");
        while (i >= 0)
        {
            número = leia.nextFloat();
            soma = soma + número;
            if (número < 0)
            {
                break;
            }
        }
        somaf = new DecimalFormat("#.###").format(soma);
        System.out.printf("A soma dos números que você digitou, até o número negativo, é %s.\n", somaf);
    }
}

