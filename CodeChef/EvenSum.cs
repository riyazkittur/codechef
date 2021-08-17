using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChef
{
   public class EvenSum
    {
        public void GetEvenSum()
        {
            int T = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < T; i++)
            {
                int N = Convert.ToInt32(Console.ReadLine());

                int[] elements = Array.ConvertAll<string, int>(Console.ReadLine().Split(' ')
                    , s => int.Parse(s));

                int sumElements = 0;
                for (int index = 0; index < elements.Length; index++)
                {
                    sumElements = sumElements + (i % 2 == 0 ? elements[index] : elements[index] * -1);
                }
                string winner = sumElements % 2 == 0 ? "1" : "2";
                Console.WriteLine(winner);

            }
        }
    }
}
