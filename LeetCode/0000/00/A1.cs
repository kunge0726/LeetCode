﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode._0000._00
{
    class A1 : IQuestion
    {
        public void Run()
        {
            throw new NotImplementedException();
        }

        //给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。

        //你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/two-sum
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>(nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                int j = 0;
                int tempValue = target - nums[i];
                if (map.TryGetValue(tempValue, out j))
                {
                    return new int[] { j, i };
                }
                map[nums[i]] = i;
            }
            return null;
        }
    }
}
