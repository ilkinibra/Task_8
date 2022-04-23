using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class Extention
    {
        public static string Capitalize(this string word )
        {
            if (word == null) return null;
            return char.ToUpper(word[0]) + word.Substring(1);
        }
    }
}
