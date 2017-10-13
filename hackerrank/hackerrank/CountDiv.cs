using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank
{
	public static class CountDiv
	{
        public static int solution(int A, int B, int K)
		{
            return B/K  - (A / K - (A % K == 0 ? 1 : 0));
		}
    }
}
