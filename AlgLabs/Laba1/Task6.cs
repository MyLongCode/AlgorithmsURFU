using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLabs.Laba1
{
    public class Task6
    {
        public static int TwoStacks(int[] arr)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            foreach(int item in arr)
            {
                if (list1.Sum(x => x) > list2.Sum(x => x)){
                    list2.Add(item);
                }
                else
                {
                    list1.Add(item);
                }
            }

            return Math.Abs(list1.Sum(x => x) - list2.Sum(x => x));
        }

        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            int[] ints = new int[n];
            for(var i = 0; i < n; i++)
                arr[i] = int.Parse(inputArray[i]);
            Console.WriteLine(TwoStacks(arr));
        }
    }
}
