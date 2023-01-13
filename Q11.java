import java.util.Scanner;

public class Q11
{
    public static Scanner leia = new Scanner(System.in);
    public static void main(String args[])
    {
        String nome[] = new String[10];
        int idade[] = new int[10], vezes = 1, i, n = 0;
        for (i = 0; i < nome.length; i ++, vezes ++)
        {
            System.out.printf("Digite o nome da %dª pessoa: ", vezes);
            leia.next();
            nome[i] = leia.nextLine();
            System.out.print("Digite a idade dela: ");
            idade[i] = leia.nextInt();
        }
        i = 0;
        while (i <= idade.length - 1)
        {
            if (idade[i] <= idade[n])
            {
                if (n == idade.length - 1)
                {
                    break;
                }
                else
                {   
                    n ++;
                }
            }
            else
            {
                n = 0;
                i ++;
            }
        }
        System.out.printf("Dentre essas pessoas, a pessoa mais nova é %s.\n", nome[i]);
    }
}