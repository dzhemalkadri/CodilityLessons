﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJmp
{
    public class Solution
    {
        public int solution(int X, int Y, int D)
        {
            double result = ((double)Y - (double)X) / (double)D;
            var count = result % 1 == 0 ? (int)result : (int)result + 1;
            return count;
        }
    }
}
