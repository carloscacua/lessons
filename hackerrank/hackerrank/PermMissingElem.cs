using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank
{
    public static class PermMissingElem
    {
        public static int solution(int[] A)
        {
                bool[] p = new bool[A.Length + 1];
                foreach (var e in A)
                {
                    p[e-1] = true;
                }

                for (int a = 0; a < p.Length; a++)
                {
                    if (!p[a])
                    {
                        return a+1;
                    }
                }
                return 0;

        }
    }
}
