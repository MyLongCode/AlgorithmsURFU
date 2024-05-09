using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgLabs.Laba5
{
    public class Task1
    {

        public static int GetHash(string value)
        {
            int num = 5381;
            int num2 = num;
            for (int i = 0; i < value.Length; i += 2)
            {
                num = (((num << 5) + num) ^ value[i]);
                if (i + 1 < value.Length)
                    num2 = (((num2 << 5) + num2) ^ value[i + 1]);
            }
            return num + num2 * 1566083941;
        }

        public static Dictionary<int, List<int>> GetSubStrings(string input)
        {
            var result = new Dictionary<int, List<int>>();
            int stringLength = input.Length;
            while (stringLength > 0)
            {
                for (var i = 0; i < input.Length - stringLength + 1; i++)
                {
                    if (!result.ContainsKey(stringLength))
                        result.Add(stringLength, new List<int> { GetHash(input.Substring(i, stringLength)) });
                    else
                        result[stringLength].Add(GetHash(input.Substring(i, stringLength)));
                }
                stringLength--;
            }
            return result;
        }

        public static int MaxWeight(Dictionary<int, List<int>> input)
        {
            int max = 0;
            foreach(var item in input)
            {
                int x = item.Value.GroupBy(y => y).Max(y => y.Count());
                x *= item.Key;
                if (x > max) max = x;
            }
            return max;
        }


        public static void Solution()
        {
            string input = Console.ReadLine();
            var subStrings = GetSubStrings(input);
            Console.WriteLine(MaxWeight(subStrings));

        }
    }
}
