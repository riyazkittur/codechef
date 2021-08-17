using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChef
{
    //Contest Code:PRACTICE Problem Code:KOL15A
    public class AlphaNumericString
    {
        public void Run()
        {
            int T = int.Parse(Console.ReadLine());

            while(T-- > 0)
            {
                string S = Console.ReadLine();
                Console.WriteLine(GetDigitsSum(S));
            }
        }
        public int GetDigitsSum(string S)
        {
            int sum = 0;
            foreach(char c in S)
            {
                if (Char.IsDigit(c))
                {
                    sum += int.Parse(c.ToString());
                }
                //if(c>=49 && c<=57)
                //{
                //    sum += int.Parse(c.ToString());
                //}
            }

            return sum;
        }
    }
}
