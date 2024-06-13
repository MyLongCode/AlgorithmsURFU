using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    internal class _2037_Minimum_Number_of_Moves_to_Seat_Everyone
    {
        public int MinMovesToSeat(int[] seats, int[] students)
        {
            Array.Sort(seats);
            Array.Sort(students);
            var res = 0;
            for(var i = 0; i < seats.Length; i++)
            {
                res += Math.Abs(students[i] - seats[i]);
            }
            return res;
        }
    }
}
