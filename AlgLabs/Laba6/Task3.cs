using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLabs.Laba6
{
    public class Task3
    {
        public static int number_groups(int[] a, int L, int N)
        {
            const short USED = -1;
            Array.Sort(a);
            int res = 0;

            for (int i = 0; i < N; ++i)
            {
                if (a[i] == USED)
                {
                    continue;
                }
                ++res;
                for (int j = i + 1; j < N; ++j)
                {
                    if (a[j] == USED)
                    {
                        continue;
                    }
                    else if (a[i] + 2 * L < a[j])
                    {
                        break;
                    }
                    else
                    {
                        a[j] = USED;
                    }
                }
            }
            return res;
        }
        public static void Solution()
        {
            int[] input = Console.ReadLine().Split().Select(t => int.Parse(t)).ToArray();
            int L = input[0];
            int N = input[1];
            int[] numbers = Console.ReadLine().Split().Select(t => int.Parse(t)).ToArray();
            Console.WriteLine(number_groups(numbers, L, N));
        }
    }
}
