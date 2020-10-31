using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ReverseWordsInAString
{
    public class Reverser
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords(Console.ReadLine()));
        }

        public static string ReverseWords(string s)
        {
            s = s.Trim();
            string pattern = "( )";
            List<string> sList = Regex.Split(s, pattern).ToList();
            sList.Reverse();
            StringBuilder sb = new StringBuilder(sList.Count());
            foreach(string x in sList)
            {
                sb.Append(x);
            }
            return sb.ToString();
        }
    }
}
