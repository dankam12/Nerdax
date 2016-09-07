using System;
using System.ComponentModel;
using System.Text;

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


    }
}
