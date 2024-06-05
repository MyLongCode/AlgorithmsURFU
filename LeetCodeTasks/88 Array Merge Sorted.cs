namespace LeetCodeTasks
{
    public class Main1
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0) nums1 = nums2;
            else if (n == 0) return;
            else
            {
                var arr = new int[m + n];
                int i = 0;
                int j = 0;
                int k = 0;
                while (i < m || j < n)
                {
                    if (nums1[i] < nums2[j] && i < m)
                    {
                        arr[k] = nums1[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = nums2[j];
                        j++;
                    }
                    k++;
                }
                nums1 = arr;
            }
            return;
            
        }

        public static void Main()
        {
            Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 0, new int[] { 1 }, 1);
            Console.ReadLine();
        }
    }
}