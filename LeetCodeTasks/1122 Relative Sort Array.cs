using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class _1122_Relative_Sort_Array
    {
        public static int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            var temp = new int[1001];
            foreach(var i in arr1)
                temp[i]++;
            var res = new int[arr1.Length];
            int index = 0;
            foreach(var item in arr2)
            {
                for(var j = 0; j < temp[item]; j++)
                {

                    res[index] = item;
                    index++;
                }
                temp[item] = 0; 
            }
            for(var i = 0; i < temp.Length; i++)
            {
                if (temp[i] > 0)
                {
                    for (var j = 0; j < temp[i]; j++)
                    {

                        res[index] = i;
                        index++;
                    }
                }
            }
            return res;
        }   
        public static void Main()
        {
            RelativeSortArray(new int[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 }, new int[] { 2, 1, 4, 3, 9, 6 });
        }
    }
}
