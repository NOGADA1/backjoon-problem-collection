public class backjoon3052
{
    public static void Main(String[] args)
    {
        int[] index1 = new int[10];
        int[] index2 = new int[10];
        int changeNumber = 1;
        for (int i = 0; i < 10; i++)
        {
            index1[i] = int.Parse(Console.ReadLine());
            index2[i] = index1[i] % 42;
        }
        Array.Sort(index2);
        for (int i = 0; i < 9; i++)
        {
            if (index2[i] != index2[i + 1])
            {
                changeNumber += 1;
            }
        }
        Console.WriteLine(changeNumber);
    }
}
