using System.Runtime.CompilerServices;
using System.Linq;
using System.Diagnostics;
public class backjoon1978
{
    public static void Main(String[] args)
    {
        int divisorCount = 0;
        int decimalCount = 0;
        int Count = int.Parse(Console.ReadLine());
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        for (int i = 0; i < Count; i++)
        {
            for (int k = 1; k <= input[i]; k++)
            {
                if (input[i] % k == 0)
                {
                    divisorCount++;
                }
            }
            if (divisorCount == 2)
            {
                decimalCount++;
            }
            divisorCount = 0;
        }
        Console.WriteLine(decimalCount);
    }
}