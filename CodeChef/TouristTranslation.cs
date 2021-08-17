using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChef
{
    public class TouristTranslation
    {
        public void Run()
        {
            string[] input = Console.ReadLine().Split(' ');
            int T = int.Parse(input[0]);
            Dictionary<char, char> keyValuePairs = new Dictionary<char, char>();
            char start = 'a';
            for(int i = 0; i < input[1].Length; i++)
            {
                
                keyValuePairs.Add(start, input[1][i]);
                start++;
            }
            start = 'A';
            for (int i = 0; i < input[1].Length; i++)
            {

                keyValuePairs.Add(start, Char.ToUpper(input[1][i]));
                start++;
            }
            keyValuePairs.Add('_', ' ');
            
            while (T-- > 0)
            {
                string languageInput = Console.ReadLine();
                StringBuilder englishOuput = new StringBuilder();
                for(int i = 0; i < languageInput.Length; i++)
                {
                    if (keyValuePairs.ContainsKey(languageInput[i]))
                    {
                        englishOuput.Append( keyValuePairs[languageInput[i]]);
                    }
                    else
                    {
                        englishOuput.Append(languageInput[i]);
                    }
                }
                Console.WriteLine(englishOuput);
            }
           
        }
    }
}
