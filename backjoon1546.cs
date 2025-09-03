using System.Runtime.CompilerServices;
using System.Linq;
using System.Diagnostics;
public class backjoon1546
{
    public static void Main(String[] args)
    {

        int Count = int.Parse(Console.ReadLine()); //입력 개수
        double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray(); //배열로 하나씩 검사 하려고 
        double Max = input.Max();
        double sum = 0;
        double newAVG = 0;
        for (int i = 0; i < Count; i++)
        {
            input[i] = (input[i] / Max) * 100;
            sum += input[i];
        }
        newAVG = sum / Count;
        Console.WriteLine(newAVG);
        
    }
}