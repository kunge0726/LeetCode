﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode._0000._20
{
    class A38 : IQuestion
    {
        public void Run()
        {
            throw new NotImplementedException();
        }

        //「外观数列」是一个整数序列，从数字 1 开始，序列中的每一项都是对前一项的描述。前五项如下：

        //1.     1
        //2.     11
        //3.     21
        //4.     1211
        //5.     111221


        //1 被读作  "one 1"  ("一个一") , 即 11。
        //11 被读作 "two 1s" ("两个一"）, 即 21。
        //21 被读作 "one 2",  "one 1" （"一个二" ,  "一个一") , 即 1211。

        //给定一个正整数 n（1 ≤ n ≤ 30），输出外观数列的第 n 项。

        //注意：整数序列中的每一项将表示为一个字符串。

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/count-and-say
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

        public string CountAndSay(int n)
        {
            if (n == 1)
            {
                return "1";
            }
            var temp = CountAndSay(n - 1);
            StringBuilder builder = new StringBuilder();
            int count = 1;
            char num = temp[0];
            for (int i = 1; i < temp.Length; i++)
            {
                if (temp[i] == num)
                {
                    count++;
                }
                else
                {
                    builder.Append(count.ToString());
                    builder.Append(num);
                    count = 1;
                    num = temp[i];
                }
            }
            builder.Append(count.ToString());
            builder.Append(num);
            return builder.ToString();
        }
    }
}
