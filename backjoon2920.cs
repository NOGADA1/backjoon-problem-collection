// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Linq;
public class backjoon2741
{
    public static void Main(string[] args)
    {
        string[] stringInputs = Console.ReadLine().Split(' ');
        int[] input = new int[8];
        for (int i = 0; i < 8; i++)
        {
            input[i] = int.Parse(stringInputs[i]);
        }
        bool isAscending = true;
        bool isDescending = true;
        for (int i = 0; i < 7; i++)
        {
            if (input[i] + 1 != input[i + 1])
            {
                isAscending = false;
            }
        }
        for (int i = 7; i >= 1; i--)
        {
            if (input[i] != input[i - 1]-1)
            {
                isDescending = false;
            }
        }
        if (isAscending == false && isDescending == false)
        {
            Console.WriteLine("mixed");
        }
        else if (isAscending == true)
        {
            Console.WriteLine("ascending");
        }
        else if (isDescending == true)
        {
            Console.WriteLine("descending");
        }
        
    }
    
}
