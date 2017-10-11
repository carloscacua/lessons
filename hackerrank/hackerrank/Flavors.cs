using System;

namespace hackerrank
{
    static class Flavors
    {

        static void PrintFlavors(long m, long n, long[] f)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (f[i] + f[j] == m)
                    {
                        Console.WriteLine(string.Format("{0} {1}", i+1, j+1 ));
                        return;
                    }
                }

            }    

        }

        static void FindFlavors()
        {
            long n, t, m;
            long[] arr;
            string[] f;
            t = Convert.ToInt64(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                m = Convert.ToInt64(Console.ReadLine());
                n = Convert.ToInt64(Console.ReadLine());
                f = Console.ReadLine().Split(' ');
                arr = new long[f.Length];
                for (int j = 0; j < n; j++)
                    arr[j] = Convert.ToInt32(f[j]);
                PrintFlavors(m, n, arr);
            }
        }

    }
}
