using System;

public class Task2
{
    public static void Main()
    {
        string input = Console.ReadLine();
        int len1 = int.Parse(input.Split()[0]);
        int len2 = int.Parse(input.Split()[1]);
        var arr1 = new int[len1];
        var arr2 = new int[len2];

        for (var i = 0; i < len1; i++)
            arr1[i] = int.Parse(Console.ReadLine());
        for (var i = 0; i < len2; i++)
            arr2[i] = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 0;
        int ans = 0;
        while (a < len1 && b < len2)
        {
            var p1 = arr1[a];
            var p2 = arr2[b];
            if (p1 == p2)
            {
                ans++;
                a++;
                b++;
            }
            else if (p1 > p2) b++;
            else a++;
        }
        Console.WriteLine(ans);

    }
}