﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            string questionId = "LCOF44";
            var types = Assembly.GetExecutingAssembly().GetTypes();
            var type = types.FirstOrDefault(t => t.Name.Equals($"{questionId}", StringComparison.OrdinalIgnoreCase));
            IQuestion question = Activator.CreateInstance(type) as IQuestion;
            question.Run();
        }
    }

}
