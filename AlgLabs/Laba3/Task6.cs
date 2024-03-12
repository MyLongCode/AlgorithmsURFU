using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLabs.Laba3
{
    public class Queue
    {
        List<int> queue { get; set; }
        int minimum;

        public Queue()
        {
            minimum = int.MaxValue;
            queue = new List<int>();
        }

        public void Clear()
        {
            queue = new List<int>();
        }

        public void Dequeue()
        {
            queue.RemoveAt(0);
            FindMin();
        }

        public void FindMin()
        {
            minimum = queue.Min();
        }

        public int Minimum()
        {
            return minimum;
        }

        public void Enqueue(int item)
        {
            if (item < minimum) minimum = item;
            queue.Add(item);
        }


    }

    public class Task6
    {
        public static void Solution()
        {
            Queue queue = new Queue();
            int M = int.Parse(Console.ReadLine());
            for(var i = 0; i < M; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "+") queue.Enqueue(int.Parse(input[1]));
                if (input[0] == "-") queue.Dequeue();
                if (input[0] == "?") Console.WriteLine(queue.Minimum());
            }
        }
    }
}
