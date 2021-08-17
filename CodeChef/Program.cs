using System;
using System.Collections;
using System.Collections.Generic;

namespace CodeChef
{
    class Program
    {

        public static void Main()
        {
            // your code goes here
            //CoinFlip coinFlip = new CoinFlip();
            //coinFlip.Run();
            int[] num = new int[] { 2,7,11,15 };

           int[]result= FindIndexPair(num, 9);

            Stack<int> st = new Stack<int>();
            st.Push(1);
            

            Console.ReadKey();

        }
        public static int[] FindIndexPair(int[] num, int target)
        {
            Hashtable hashtable = new Hashtable();
            int[] result=null;
            for (int i = 0; i< num.Length; i++)
            {
                hashtable[num[i]] = i;
            }

            for(int i = 0; i < num.Length; i++)
            {
                if (Convert.ToInt32(hashtable[target - num[i]]) != i)
                {
                   result = new int[] { i, Convert.ToInt32(hashtable[target - num[i]]) };
                    return result;
                    
                }
            }
            return result;
        }

    }
    
}
