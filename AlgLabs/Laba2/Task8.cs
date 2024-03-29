using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AlgLabs.Laba2
{
    public class Pair
{
    public int first;
    public int second;

    public Pair(int first, int second)
    {
        this.first = first;
        this.second = second;
    }
}


    public class Task8
    {

        public static bool CheckMinusOneGuard(List<Pair> guards, int deletedItemId)
        {
            if (guards.Count < 2) return false;
            var list = new List<Pair>(guards);
            list.RemoveAt(deletedItemId);
            var flag = false;
            for(int i = 0; i < list.Count - 1; i++)
            {
                if (list[i].second <= list[i+1].first)
                    return false;
                if (list[i].second == 10000) flag = true;
            }
            if (list[list.Count - 1].second == 10000) flag = true;
            if (list[0].first != 0 || !flag) return false;
            return true;
        }
        public static string CheckTest(List<Pair> list)
        {
            list = list.OrderBy(x => x.first).ToList();

            for (int i = 0; i < list.Count; ++i)
                if (CheckMinusOneGuard(list, i)) return "Wrong Answer";
            return "Accepted";
        }
        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine());
            List<Pair>[] listInputs = new List<Pair>[n];
            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                var list = new List<Pair>();
                for (int j = 1; j < input.Length; j += 2)
                {
                    var item = new Pair(int.Parse(input[j]), int.Parse(input[j + 1]));
                    list.Add(item);
                }
                listInputs[i] = list;
            }

            foreach (var item in listInputs)
                Console.WriteLine(CheckTest(item));
        }
    }
}
