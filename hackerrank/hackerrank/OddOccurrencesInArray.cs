using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank
{
    struct Elem
    {
        public int value;
        public int ocurrences;
    }

    static class OddOccurrencesInArray
    {
        public static int iterativeSolution(int[] A)
        {
            bool[] posibleOdd = new bool[A.Length];
            for (int i = 0; i < posibleOdd.Length; i++)
            {
                posibleOdd[i] = true;
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (posibleOdd[i])
                {
                    int j;
                    for (j = i + 1; j < A.Length; j++)
                    {
                        if (A[i] == A[j])
                        {
                            posibleOdd[i] = posibleOdd[j] = false;
                        }
                    }
                    if (j == A.Length && posibleOdd[i])
                    {
                        return A[i];
                    }

                }
                
            }
            return 0;

        }

        public static int dictSolution(int[] A)
        {
            var occurrences = new Dictionary<int, int>();
            foreach (var elem in A)
            {
                occurrences[elem] = occurrences.ContainsKey(elem) ? occurrences[elem] + 1 : 1;
            }

            foreach (var elem in occurrences)
            {
                if (elem.Value % 2 == 1)
                {
                    return elem.Key;
                }
            }
            return 0;
        }

    }
}
