using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank
{
    public static class ZeroIndexedArray
    {
        public static int[] solution(int[] A, int K)
        {
            var  s = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                s[(i + K)%A.Length] = A[i];
            }
            return s;

        }
    }
}
