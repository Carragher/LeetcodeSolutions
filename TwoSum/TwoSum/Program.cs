using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                Dictionary<int, int> map = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    if (map.ContainsKey(target - nums[i]))
                    {
                        return new int[] { i, map[target - nums[i]] };
                    }
                    else if (!map.ContainsKey(nums[i]))
                    {
                        map.Add(nums[i], i);
                    }
                }

                throw new NotImplementedException();


                //brute force
                //int index = 0;
                //foreach (var currentNumber in nums)
                //{

                //    for (int i = 0; i < nums.Length; i++)
                //    {
                //        if (i == index)
                //        {
                //            continue;
                //        }

                //        if (currentNumber + nums[i] == target)
                //        {
                //            return new int[] { index, i };


                //        }
                //    }

                //    index++;
                //}


                Console.WriteLine("Hello World!");
            }
        }
    }
}
