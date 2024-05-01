using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLabs.Laba5
{
    public class Task4
    {
        public static bool IsPerfectSquareBinarySearch(long num)
        {
            if (num < 2)
                return true;

            long left = 2;
            long right = num / 2;

            while (left <= right)
            {
                long mid = left + (right - left) / 2;
                long square = mid * mid;

                if (square == num)
                    return true;
                else if (square < num)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return false;
        }

        public static void Solution()
        {
            int inputLength = int.Parse(Console.ReadLine());
            for (var i = 1; i <= inputLength; i++)
            {
                long input = long.Parse(Console.ReadLine());
                if (IsPerfectSquareBinarySearch(input)) Console.WriteLine(i);
            }
                
        }
    }
}
