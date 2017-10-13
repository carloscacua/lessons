using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank
{
    public static class MaxProductOfThree
    {
        public static int solution(int[] A)
        {
            Array.Sort(A);

            return Math.Max(A[0] * A[1] * A[A.Length - 1] , A[A.Length - 2] * A[A.Length - 1]*A[A.Length - 3]);
        }
    }
}
