using ForAlgorithms.Sorts;

namespace Algorithms
{
    class Algorithms
    {
        public static void Main()
        {
            var arr = new int[10]
            {
                10,2,129,4,9,324,7,8,3910,10
            };
            arr = Sorts.SelectionSort(arr);
            foreach (int i in arr)
                Console.WriteLine(i);
        }
    }
        
}
