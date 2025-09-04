using System.Runtime.CompilerServices;
using System.Linq;
using System.Diagnostics;
public class backjoon2609
{
    public static void Main(String[] args)
    {

        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int num1 = input[0];
        int num2 = input[1];
        int GCD = 0;
        int LCM = num1 * num2;
        while (true)
        {
            int remain = num1 % num2;
            num1 = num2;
            num2 = remain;
            if (remain == 0)
            {
                GCD = num1;
                break;
            }


        }
        LCM /= GCD; 
        Console.WriteLine(GCD +" "+ LCM);
        
    }
}