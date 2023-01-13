import java.util.Scanner;
import java.text.DecimalFormat;

public class Q12
{
    public static Scanner leia = new Scanner(System.in);
    public static void main(String args[])
    {
        float número, resultado;
        String númerof, resultadof; 
        System.out.print("Digite um número: ");
        número = leia.nextFloat();
        númerof = new DecimalFormat("#.######").format(número);
        System.out.println("A tabuada de multiplicação de 1 à 10 deste número é:");
        for (int multiplicador = 1; multiplicador <= 10; multiplicador ++)
        {
            resultado = número * multiplicador;
            resultadof = new DecimalFormat("#.###").format(resultado);
            System.out.println(númerof + " x " + multiplicador + " = " + resultadof + ".");
        }
    }
}