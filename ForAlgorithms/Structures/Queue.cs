using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAlgorithms.Structures
{
    public class Queue<T>
    {
        List<T> queue { get; set; }

        public void Clear()
        {
            queue = new List<T>();
        }

        public T Dequeue()
        {
            var temp = queue[0];
            queue.RemoveAt(0);
            return temp;
        }

        public void Enqueue(T Item)
        {
            queue.Add(Item);
        }


    }
}
