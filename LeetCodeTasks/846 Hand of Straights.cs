﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class Hand_of_Straights
    {
        public static bool IsNStraightHand(int[] hand, int groupSize)
        {
                if (hand.Length % groupSize != 0) return false;
                Array.Sort(hand);
                bool flag = true;
                    for(int j = 0; j < hand.Length / groupSize; j++)
                    {
                        int[] nums = new int[groupSize];
                        for(int i = 0; i < nums.Length; i++)
                            nums[i] = int.MinValue;
                        int count = 0;
                        for (int k = 0; k < hand.Length; k++)
                        {
                            if (hand[k] != -1 && (nums.Contains(hand[k] - 1) || nums[0] == int.MinValue) && !nums.Contains(hand[k]))
                            {
                                nums[count] = hand[k];
                                hand[k] = -1;
                                count++;
                            }
                            if (count == groupSize) 
                                break;
                        }
                        
                    
                    }

                foreach (var item in hand)
                    if (item != -1) flag = false;
                return flag;
            
        }

        public static bool SecondSolution(int[] hand, int groupSize)
        {
            if (hand.Length % groupSize != 0)
                return false;

            var hashMap = new Dictionary<int, int>();
            foreach (var item in hand)
            {
                hashMap[item] = hashMap.GetValueOrDefault(item, 0) + 1;
            }
            Array.Sort(hand);

            foreach (int num in hand)
            {
                if (hashMap[num] > 0)
                {
                    for (int i = num + 1; i < num + groupSize; i++)
                    {
                        if (!hashMap.ContainsKey(i))
                            return false;
                        if (hashMap[i] == 0)
                            return false;

                        hashMap[i]--;
                    }

                    hashMap[num]--;
                }
            }

            return true;
        }

        public static void Main()
        {
            IsNStraightHand(new int[] { 1,2,3,4,5,6,7,8,9 }, 3);
        }
    }
}
