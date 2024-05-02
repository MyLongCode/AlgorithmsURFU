using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLabs.Laba6
{
    public class Task3
    {
        public static void Solution()
        {
            int[] input = Console.ReadLine().Split().Select(t => int.Parse(t)).ToArray();
            int L = input[0];
            int N = input[1];
            int[] numbers = Console.ReadLine().Split().Select(t => int.Parse(t)).ToArray();
            Array.Sort(numbers);
            int center = numbers[0];
            int counter = 0;
            for (int i = 1; i < N; i++)
            {
                if (numbers[i] - center <= L) continue;
                center = numbers[i];
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
