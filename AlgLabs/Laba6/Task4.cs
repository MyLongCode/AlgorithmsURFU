using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLabs.Laba6
{
    public class Task4
    {
        public static bool IsPrime(long number)
        {
            if (number <= 1)
                return false;
            else if (number % 2 == 0)
                return number == 2;

            long N = (long)(Math.Sqrt(number) + 0.5);

            for (int i = 3; i <= N; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static void Solution()
        {
            int[] input = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            int M = input[0];
            int N = input[1];

            int i = 2;
            int answer = -1;
            while (i < 2000000)
            {
                int count = 0;
                for(var j = i; j < i + N; j ++)
                {
                    if (IsPrime(j)) count++;
                    if (count > M) break;
                }
                if (count == M)
                {
                    answer = i;
                    break;
                }
                i++;
            }
            Console.WriteLine(answer);

        }
    }
}
