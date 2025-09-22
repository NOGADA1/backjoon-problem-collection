using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Text;
public class Backjoon2751
{

    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine()); // 정렬할 수의 횟수를 입력받음
        var list = new List<int>(); // 배열로 했다가 안돼서 리스트로 만들어봄
        StringBuilder output = new StringBuilder(); // Console.WriteLine이 뒤지게 느려서 스트링 빌더로 한꺼번에 만들고 출력하기위해 스트링빌더 사용
        for (int i = 0; i < num; i++) // 리스트 입력
        {
            list.Add(int.Parse(Console.ReadLine()));
        }
        list.Sort(); //정렬 함수

        for (int i = 0; i < list.Count; i++) // 스트링빌더에 리스트 값을 추가
        {
            output.Append(list[i]+"\n");
        }
        Console.WriteLine(output); //한번에 출력
    }
}
