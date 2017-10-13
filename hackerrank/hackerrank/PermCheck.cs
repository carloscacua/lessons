using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank
{
    static class PermCheck
    {
        public static int solution(int[] A)
		{
            var dict = new Dictionary<int, int>();
            foreach (var i in A)
            {
                if (dict.ContainsKey(i) || (i<=0 || i>A.Length))
                    return 0;
                dict[i] = 1;
            }
            return 1;

		}
    }
}
