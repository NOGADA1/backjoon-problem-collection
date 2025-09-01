using System.Runtime.CompilerServices;
using System.Linq;
using System.Diagnostics;
public class backjoon4153
{
    public static void Main(String[] args)
    {
        int hypo = 0;
        int adj = 0;
        int opp = 0;
        while (true)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(input);
            hypo = input[2];
            adj = input[1];
            opp = input[0];
            if (hypo == 0 && adj == 0 && opp == 0)
            {
                break;
            }
            if (Math.Pow(hypo, 2) != Math.Pow(adj, 2) + Math.Pow(opp, 2))
            {
                Console.WriteLine("Wrong");
            }
            else if (Math.Pow(hypo, 2) == Math.Pow(adj, 2) + Math.Pow(opp, 2))
            {
                Console.WriteLine("Right");
            }

        }
    }
}