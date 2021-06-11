using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public static class VasyaClerk
    {
        public static string Tickets(int[] peopleInLine)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0;  i < peopleInLine.Length; i++)
            {
                var key = peopleInLine[i];

                if (dict.ContainsKey(key))
                {
                    var value = dict.GetValueOrDefault(key) + 1;
                    dict.Remove(key);
                    dict.Add(key, value);
                }
                else
                {
                    dict.Add(key, 1);
                }

                if(key > 25)
                {

                }
            }
            return "no";
        }
    }
}
