﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode._0100._20
{
    class A121 : IQuestion
    {
        public void Run()
        {
            throw new NotImplementedException();
        }

        //给定一个数组，它的第 i 个元素是一支给定股票第 i 天的价格。

        //如果你最多只允许完成一笔交易（即买入和卖出一支股票一次），设计一个算法来计算你所能获取的最大利润。

        //注意：你不能在买入股票前卖出股票。

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
            {
                return 0;
            }
            int min = int.MaxValue;
            int max = 0;
            foreach (var p in prices)
            {
                if (p < min)
                {
                    min = p;
                }
                max = Math.Max(max, p - min);
            }
            return max;
        }
    }
}
