using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChef
{
   public class CoinFlip
    {
        public void Run()
        {
            int T = int.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int numberOfGames = int.Parse(Console.ReadLine());
                while(numberOfGames-- > 0)
                {
                    int[] input = Array.ConvertAll(Console.ReadLine().Split(' ')
                        , s => int.Parse(s));
                    //char[] coins = new char[input[1]];
                    int N = input[1];
                    int headCount = 0;
                    int tailCount = 0;
                    if (N % 2 == 0)
                    {
                        int evenCount = N/2;
                        
                        //if (input[0] == 1)
                        //{
                        //    headCount = N - evenCount;
                        //    tailCount = evenCount;
                        //}
                        //else
                        //{
                        //    headCount = evenCount;
                        //    tailCount = N - evenCount;
                        //}
                        //int result = input[2] == 1 ? headCount : tailCount;
                        Console.WriteLine(N/2);
                    }
                    else
                    {
                        int oddCount = ((N-1)/2 )+ 1;
                        
                        if (input[0] == 1)
                        {
                            headCount = N - oddCount;
                            tailCount = oddCount;
                        }
                        else
                        {
                            headCount = oddCount;
                            tailCount = N - oddCount;
                        }
                        int result = input[2] == 1 ? headCount : tailCount;
                        Console.WriteLine(result);
                    }
                    
                   
                }
            }
        }
    }
}
