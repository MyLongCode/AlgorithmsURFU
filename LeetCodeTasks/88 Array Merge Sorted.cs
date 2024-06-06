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

        public static void Main()
        {
            Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 0, new int[] { 2,5,6 }, 3);   
        }
    }
}