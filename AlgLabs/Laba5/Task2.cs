using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLabs.Laba5
{
    public class Task2
    {
        public static void Solution()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            int length = int.Parse(Console.ReadLine());
            for(int i = 0; i < length; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "ADD")
                {
                    string key = input[1];
                    string value = input[2];
                    if (dict.ContainsKey(key)) Console.WriteLine("ERROR");
                    else dict[key] = value;
                }
                if (input[0] == "DELETE")
                {
                    if (dict.ContainsKey(input[1])) Console.WriteLine("ERROR");
                    else dict.Remove(input[1]);
                }
                if(input[0] == "UPDATE")
                {

                }
            }
        }
    }
}
