using System.Collections.Generic;
using System;

public class Task1
{
    public static void Solution()
    {
        string str = "1 2 6 8 7 3 0 4 1 6 2 3 9 0";
        var array = str.Split();
        bool flag = true;
        var list1 = new List<int>();
        var list2 = new List<int>();
        foreach (string item in array)
        {
            int x = int.Parse(item);
            if (flag == true && x != 0) list1.Add(x);
            else if (flag == false && x != 0) list2.Add(x);
            else if (x == 0) flag = false;
        }
        list1 = list1.Distinct().ToList();
        list2 = list2.Distinct().ToList();
        var dict = new Dictionary<int, byte>();
        foreach (int x in list1)
        {
            if (!dict.ContainsKey(x)) dict[x] = 1;
            else dict[x]++;
        }
        foreach (int x in list2)
        {
            if (!dict.ContainsKey(x)) dict[x] = 1;
            else dict[x]++;
        }
        var ans = new List<int>();
        foreach (var item in dict)
            if (item.Value == 1) ans.Add(item.Key);
        ans.Sort();
        foreach (var item in ans)
            Console.Write(item + " ");

    }
}