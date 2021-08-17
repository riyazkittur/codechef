using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChef
{
    public class PrettyNumbers
    {
        public void Run()
        {
            List<int> prettyNumbers = new List<int> { 2, 3, 9 };
            int T = int.Parse(Console.ReadLine().Trim());

            while (T-- > 0)
            {
                int count = 0;
                int[] Numbers = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),
               s => int.Parse(s));

                if (Numbers != null)
                {
                    if (Numbers.Length == 1)
                    {
                        count = prettyNumbers.Contains(Numbers[0] % 10) ? 1 : 0;
                        Console.WriteLine(count);
                        continue;
                    }
                    else
                    {
                        int startNumber = Numbers[0];
                        int endNumber = Numbers[1];
                        for (int index = startNumber; index <= endNumber; index++)
                        {
                            if (prettyNumbers.Contains(index % 10))
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                    }
                }
            }
        }
    }
}
