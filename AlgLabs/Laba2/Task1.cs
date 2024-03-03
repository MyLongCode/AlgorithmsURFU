using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLabs.Laba2
{
    public class Task1
    {

        public static int[] BubbleSort(int[] arr)
        {
            bool flag = false;
            while (!flag)
            {
                flag = true;
                for(var i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i + 1];
                        arr[i+1] = arr[i];
                        arr[i] = temp;
                        flag = false;
                    }
                }
            }
            return arr;
        }

        public static int MaxTrio(int[] arr)
        {
            arr = BubbleSort(arr);
            if (arr[0] * arr[1] > arr[arr.Length - 1] * arr[arr.Length - 2])
                return arr[0] * arr[1] * arr[arr.Length - 1];
            return arr[arr.Length - 1] * arr[arr.Length - 2] * arr[arr.Length - 3];
        }

        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = new int[n];
            for (var i = 0; i < n; i++)
                ints[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(MaxTrio(ints));

        }
    }
}
