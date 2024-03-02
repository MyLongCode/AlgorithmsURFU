namespace Algorithms
{
    class Sorts
    {
        public static int[] BubbleSort(int[] arr)
        {
            bool flag = true;
            while (flag == true){
                flag = false;
                for (var i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        flag = true;
                    }
                }
            }
            
            return arr;
        }
        public static int[] SelectionSort(int[] arr)
        {
            for (var i = arr.Length - 1; i > 0; i--)
            {
                int max = int.MinValue;
                int k = 0;
                for (var j = 0; j < i; j++)
                {
                    if (max <= arr[j]) 
                    {
                        k = j;
                        max = arr[j];
                    } 
                }
                int temp = arr[i];
                arr[i] = max;
                arr[k] = temp;
            }
                
            return arr;
        } 
        public static void Main()
        {
            var arr = new int[10]
            {
                10,2,129,4,9,324,7,8,3910,10
            };
            arr = SelectionSort(arr);
            foreach (int i in arr)
                Console.WriteLine(i);
        }
    }
}