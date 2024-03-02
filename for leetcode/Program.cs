public class Laba1
{
    public static void Main()
    {
        string x = Console.ReadLine();
        string operation = Console.ReadLine();
        string y = Console.ReadLine();
        Console.WriteLine(plus(x,y));

    }

    public static string plus(string x, string y)
    {
        var arr1 = x.Reverse().Select(i => i - '0').ToArray();
        var arr2 = y.Reverse().Select(i => i - '0').ToArray();
        string ans = "";
        int c = 0;
        for(int i = 0; i < arr1.Length; i++)
        {
            int p1 = arr1[i];
            int p2 = arr2[i];
            c = p1 + p2 + c;
            ans += c % 10;
            c /= 10;
        }
        var ansArray = ans.ToCharArray();
        Array.Reverse(ansArray);
        return new string(ansArray);
    }
}
