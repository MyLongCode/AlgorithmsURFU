using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class ListNode
    {
          public int val;
          public ListNode next;
          public ListNode(int val = 0, ListNode next = null)
          {
                this.val = val;
                this.next = next;
          }
    }
    internal class _21_Merge_Two_Sorted_Lists
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var ans = new ListNode(0,new ListNode());
            var ansNext = ans.next;
            if (list1 == null && list2 == null) return null;
            while(list1 != null || list2 != null)
            {
                ansNext.next = new ListNode();
                ansNext = ansNext.next;
                if (list2 == null || (list1 != null && list1.val < list2.val) )
                {
                    ansNext.val = list1.val;
                    list1 = list1.next;
                }
                else
                {
                    ansNext.val = list2.val;
                    list2 = list2.next;
                }
                
            }
            ansNext.next = null;
            ans = ans.next.next;
            return ans;
        }

        public static void Main(string[] args) 
        {
            var node1 = new ListNode(1);
            var node2 = new ListNode(2, node1);
            var node3 = new ListNode(6, node2);
            var node4 = new ListNode(4);
            var node5 = new ListNode(5, node4);
            MergeTwoLists(node3, node5);
        }
    }
}
