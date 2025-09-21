using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

public class Backjoon2751
{

    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        var list = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }
        list.Sort();
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}
