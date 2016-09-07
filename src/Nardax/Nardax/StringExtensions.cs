using System;
using System.ComponentModel;
<<<<<<< HEAD
using System.Text;
=======
using System.Text.RegularExpressions;
>>>>>>> 760310c420e070f0f1353021a2101d31f48f8125

namespace Nardax
{
    public static class StringExtensions
    {
        //klipper av en sträng från vänster
        public static string TruncateLeft(this string value, int maxLength)
        {
            var startIndex = value.Length - maxLength;

            if (startIndex < 1)
            {
                return value;
            }

            return value.Substring(startIndex, maxLength);
        }
        // klipper av en sträng från höger

        public static string TruncateRight(this string value, int maxLength)
        {
            if (value.Length < maxLength)
            {
                return value;
            }

            return value.Substring(0, maxLength);
        }


















        public static string Repeat(this string value,int times)

        { var sb = new StringBuilder();

            for (int i = 0; i < times; i++)
            {
                sb.Append(value);
            }
            return sb.ToString();
        }



        public static string RemoveWhiteChars(this string value)

        {
            return Regex.Replace(value, "\\s","");
        }


    }
}
