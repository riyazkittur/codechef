using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChef
{
	public class LittleElephant
	{
		public  void FindGoodNumber()
		{
			// your code goes here
			int T = Convert.ToInt32(Console.ReadLine());


			for (int i = 0; i < T; i++)
			{
				int N = Convert.ToInt32(Console.ReadLine());

				int[] elements = Array.ConvertAll<string, int>(Console.ReadLine().Split(' ')
					, s => int.Parse(s));
				
				Console.WriteLine(IsPermutationGood(elements, N));

			}



		}
		public static string IsPermutationGood(int[] A, int N)
		{
			int numberOfInversions = 0;
			int numberOfLocal = 0;
			if (N == 1)
			{
				return "YES";
			}

			else
			{

				for (int i = 0; i < N - 1; i++)
				{
					for (int j = i + 1; j < N; j++)
					{
						if (A[i] > A[j])
						{
							numberOfInversions += 1;
							if ((j - i) == 1)
							{
								numberOfLocal += 1;
							}
						}
					}
				}

			}
			return numberOfInversions == numberOfLocal ? "YES" : "NO";
		}
	}
}
