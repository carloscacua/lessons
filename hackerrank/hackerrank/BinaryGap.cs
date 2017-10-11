using System;

namespace hackerrank
{
    static class BinaryGap
    {
        public static int solution(int N)
        {
            var s = Convert.ToString(N, 2);

            int max = 0;
            bool inBG = false;
            int current = 0;
            bool lastWas1 = false;

            foreach(char c in s)
            {
                if(c == '0' )
                {
                    if (inBG || lastWas1)
                    {
                        current++;
                        inBG = true;
                    }
                    lastWas1 = false;
                }
                else if (c == '1')
                {
                    lastWas1 = true;
                    if(inBG)
                    {
                        max = Math.Max(max, current);
                        current = 0;
                        inBG = false;
                    }else
                    {
                        inBG = true;
                    }
                }
            }
            return max;

        }
    }
}
