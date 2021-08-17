using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChef
{
    public class DividingStamps
    {
        public void Run()
        {
            long N = int.Parse(Console.ReadLine());
            long[] stampsCount = Array.ConvertAll(Console.ReadLine().Split(' '),
                s => long.Parse(s));
            long expectedSum = N * (N + 1) / 2;

            long actualSum = 0;
            for (int i= 0;i <stampsCount.Length;i++)
            {
                actualSum += stampsCount[i];
            }
            string result = expectedSum == actualSum ? "YES" : "NO";
            Console.WriteLine($"{result}");

        }
    }
}
