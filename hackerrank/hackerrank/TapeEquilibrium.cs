using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank
{
    static class TapeEquilibrium
    {
        public static int solution(int[] A)
        {
            var l = 0;
            var min = Int32.MaxValue;
            var  r = A.Aggregate((x, y) => x + y);

            for (int i = 0; i < A.Length -1; i++)
            {
                l += A[i];
                r -= A[i];
                min = Math.Min(min, Math.Abs(l - r));
            }
            return min;
            
        }
    }
}
