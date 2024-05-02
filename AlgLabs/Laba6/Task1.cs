using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLabs.Laba6
{
    public class Task1
    {
        public static int MaximalSubarraysSum(int[] arr)
        {
            int len = arr.Length;
            int res = int.MinValue;
            int sum = 0;
            for(var i = 0; i < len; i++)
            {
                sum += arr[i];
                if (sum > res) res = sum;
                if (sum < 0) sum = 0;
            }
            return res;
        }

        public static void Solution()
        {
            int inputLength = int.Parse(Console.ReadLine());
            int[] arr = new int[inputLength];
            for (var i = 0; i < inputLength; i++)
            {
                var item = int.Parse(Console.ReadLine());
                arr[i] = item;
            }
            Console.WriteLine(MaximalSubarraysSum(arr));
        }
    }
}
