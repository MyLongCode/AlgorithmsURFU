using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    internal class _502_IPO
    {
        public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
        {
            if (profits == null || capital == null || profits.Length == 0 || profits.Length != capital.Length)
            {
                return 0;
            }

            var capitalDict = new Dictionary<int, PriorityQueue<int, int>>();
            var priorityQueueKeys = new PriorityQueue<int, int>();
            var priorityQueueValues = new PriorityQueue<int, int>(new IntMaxCompare());
            var maxUnlockableKey = 0;

            for (int i = 0; i < capital.Length; i++)
            {
                if (!capitalDict.ContainsKey(capital[i]))
                {
                    capitalDict[capital[i]] = new(new IntMaxCompare());
                    priorityQueueKeys.Enqueue(capital[i], capital[i]);
                }

                capitalDict[capital[i]].Enqueue(profits[i], profits[i]);
                maxUnlockableKey = Math.Max(capital[i], maxUnlockableKey);
            }

            var currentCapital = w;
            var currentCapitalWasChanged = true;

            while (k > 0)
            {
                if (currentCapitalWasChanged && priorityQueueKeys.Count > 0)
                {
                    while (priorityQueueKeys.TryPeek(out var _, out var p) && p <= currentCapital)
                    {
                        var key = priorityQueueKeys.Dequeue();

                        while (capitalDict[key].Count > 0)
                        {
                            var top = capitalDict[key].Dequeue();
                            priorityQueueValues.Enqueue(top, top);
                        }
                    }

                    currentCapitalWasChanged = false;
                }

                if (priorityQueueValues.Count == 0)
                {
                    break;
                }

                var max = priorityQueueValues.Dequeue();

                if (max != 0 && currentCapital < maxUnlockableKey)
                {
                    currentCapitalWasChanged = true;
                }

                currentCapital += max;
                k--;
            }

            return currentCapital;
        }

        private class IntMaxCompare : IComparer<int>
        {
            public int Compare(int x, int y) => y.CompareTo(x);
        }
    }
}
