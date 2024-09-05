using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Converter
    {
        public static string From10(int a, int n = 2)
        {
            n = Math.Max(Math.Min(n, 36), 2);
            string result = "";

            while (a > 0)
            {
                int rem = a % n;

                if (rem > 9)
                    result = ((char)('A' + (rem - 10))).ToString() + result;

                else
                    result = rem.ToString() + result;

                a /= n;
            }

            return result;
        }

        public static int To10(string s, int n = 2)
        {
            n = Math.Max(Math.Min(n, 36), 2);
            int result = 0;

            if (s == null || s.Length < 1)
                return 0;

            int step = s.Length - 1;

            foreach (char c in s.ToUpper())
            {
                if (c <= '9' && c >= '0')
                    result += (int)((c - '0') * Math.Pow(n, step));

                if (c <= 'Z' && c >= 'A')
                    result += (int)((c - 'A' + 10) * Math.Pow(n, step));

                step--;
            }

            return result;
        }
    }
}
