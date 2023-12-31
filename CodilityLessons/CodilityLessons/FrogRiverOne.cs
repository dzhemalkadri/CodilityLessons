﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityLessons
{
    public class FrogRiverOne
    {
        public int Solution(int X, int[] A)
        {
            int[] B = new int[X];
            int leaves = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (B[A[i] - 1] == 0)
                {
                    B[A[i] - 1]++;
                    leaves++;
                    if (leaves == X) return i;
                }
            }
            return -1;
        }
    }
}
