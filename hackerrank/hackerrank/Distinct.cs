using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank
{
	public static class Distinct
	{
		public static int solution(int[] A)
		{
			var dict = new Dictionary<int, bool>();

			foreach (var i in A)
			{
				dict[i] = true;
			}
			return dict.Count();

		}
	}
}
