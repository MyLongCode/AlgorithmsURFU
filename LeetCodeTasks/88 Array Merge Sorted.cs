namespace LeetCodeTasks
{
    public class Main1
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
           for(int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            Array.Sort(nums1);
        }

        public static void Merge1(int[] nums1, int m, int[] nums2, int n)
        {
            int cursor1 = m - 1;
            int cursor2 = n-1;
            for(int i = nums1.Length - 1; i >= 0 && cursor2 >= 0; i--)
            {
                int n1 = int.MinValue;
                if (cursor1 >= 0) n1 = nums1[cursor1];
                int n2 = nums2[cursor2];

                if (n1 < n2)
                {
                    nums1[i] = n2;
                    cursor2--;
                }
                else
                {
                    nums1[i] = n1;
                    cursor1--;
                }

            }
            return;
        }

        public static void Main()
        {
            Merge1(new int[] { 1, 2, 3, 0, 0, 0 }, 0, new int[] { 2,5,6 }, 3);   
        }
    }
}