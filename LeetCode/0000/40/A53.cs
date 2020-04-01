﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode._0000._40
{
    class A53 : IQuestion
    {
        public void Run()
        {
            throw new NotImplementedException();
        }

        //给定一个整数数组 nums ，找到一个具有最大和的连续子数组（子数组最少包含一个元素），返回其最大和。

        //示例:

        //输入: [-2,1,-3,4,-1,2,1,-5,4],
        //输出: 6
        //解释: 连续子数组[4, -1, 2, 1] 的和最大，为 6。

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/maximum-subarray
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

        public int MaxSubArray(int[] nums)
        {
            if(nums.Length == 0)
            {
                return 0;
            }
            int max = nums[0];
            int sum = max;
            for (int i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum < nums[i])
                {
                    max = Math.Max(max, nums[i]);
                    sum = nums[i];
                }
                else
                {
                    max = Math.Max(max, sum);
                }
            }
            return max;
        }
    }
}
