using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef
{
    public class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            string[] final = new string[names1.Length + names2.Length];
            names1.CopyTo(final, 0);
            names2.CopyTo(final, names1.Length);

            return final.Distinct().ToArray();
        }

        public  void Run()
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        }

       
    }
}
