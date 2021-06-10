using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public static class ReverseWords
    {
        public static string Reverse(string str)
        {
            var strings = str.Split(' ');

            string x = string.Empty;

            for (int z = 0; z < strings.Length; z++)
            {
                for (int i = (strings[z].Length - 1); i >= 0; i--)
                    x += strings[z][i];
                x += " ";
            }

            return x.TrimEnd;
        }
    }
}
