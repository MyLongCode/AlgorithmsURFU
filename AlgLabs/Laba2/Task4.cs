using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLabs.Laba2
{
    public class Task4
    {
        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                Sort(arr, left, pivot - 1);
                Sort(arr, pivot + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp1;

            return i + 1;
        }

        public static void Solution()
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);
            int M = int.Parse(input[2]);
            int L = int.Parse(input[3]);

            int[] arr = new int[N];

            int prev = K;
            int curr;
            arr[0] = prev;
            for (int i = 1; i < N; i++)
            {
                curr = ((int)((prev * M) % (Math.Pow(2, 32) - 1) % L));
                arr[i] = curr;
                prev = curr;
            }
            Sort(arr, 0, arr.Length - 1);

            int result = 0;
            for (int i = 0; i < N; i += 2)
                result += arr[i];
            Console.WriteLine(result%L);
        }
    }
}
