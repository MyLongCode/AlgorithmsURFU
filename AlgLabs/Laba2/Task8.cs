using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLabs.Laba2
{
    public class Task8
    {

        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] array = new int[3][];
            array[0][2] = 1;
            foreach (var item in array)
                Console.WriteLine(item);

        }
    }
}
