﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode._0000._20
{
    class A31 : IQuestion
    {
        public void Run()
        {
            throw new NotImplementedException();
        }

        //实现获取下一个排列的函数，算法需要将给定数字序列重新排列成字典序中下一个更大的排列。

        //如果不存在下一个更大的排列，则将数字重新排列成最小的排列（即升序排列）。

        //必须原地修改，只允许使用额外常数空间。

        //以下是一些例子，输入位于左侧列，其相应输出位于右侧列。
        //1,2,3 → 1,3,2
        //3,2,1 → 1,2,3
        //1,1,5 → 1,5,1

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/next-permutation
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

        public void NextPermutation(int[] nums)
        {
            int i = nums.Length - 2;
            while(i >= 0 && nums[i + 1] <= nums[i])
            {
                i--;
            }
            if(i >= 0)
            {
                int j = nums.Length - 1;
                while(j > i && nums[j] <= nums[i])
                {
                    j--;
                }
                Swap(nums, i, j);
            }
            Reverse(nums, i + 1);
        }

        private void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        private void Reverse(int[] nums, int start)
        {
            int end = nums.Length - 1;
            while(start < end)
            {
                Swap(nums, start, end);
                start++;
                end--;
            }
        }

    }
}
