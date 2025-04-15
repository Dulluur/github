using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringFunctionsLab
{
    class StringFunctions
    {
        public static string Concat(string s1, string s2)
        {
            return s1 + s2;
        }

        public static string Reverse(string s1)
        {
            string res = "";

            for (int i = s1.Length - 1; i >= 0; --i)
            {
                res += s1[i];
            }
            return res;
        }

        public static string Trim(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            int start = 0;
            int end = s.Length - 1;

            while (start <= end && s[start] == ' ')
            {
                start++;
            }

            while (end >= start && s[end] == ' ')
            {
                end--;
            }

            char[] result = new char[end - start + 1];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = s[start + i];
            }

            return new string(result);
        }
        public static string Left(string s, int l)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            char[] result;
            if (s.Length > l)
            {
                result = new char[l];
                for (int i = 0; i < l; i++)
                {
                    result[i] = s[i];
                }
            }
            else
            {
                result = new char[l];
                for (int i = 0; i < s.Length; i++)
                {
                    result[i] = s[i];
                }
                for (int i = s.Length; i < l; i++)
                {
                    result[i] = ' ';
                }
            }
            return new string(result);
        }
        public static string Right(string s, int n)
        {
            char[] result;
            if (s.Length > n)
            {
                result = new char[n];
                for (int i = 0; i < n; i++)
                {
                    result[i] = s[s.Length - n + i];
                }
            }
            else
            {
                result = new char[n];
                int offset = n - s.Length;
                for (int i = 0; i < offset; i++)
                {
                    result[i] = ' ';
                }
                for (int i = 0; i < s.Length; i++)
                {
                    result[offset + i] = s[i];
                }
            }
            return new string(result);
        }
        public static string Copies(string s, int n)
        {
            char[] result = new char[s.Length * n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    result[i * s.Length + j] = s[j];
                }
            }
            return new string(result);
        }
        public static string Insert(string s1, string s2, int n)
        {
            string result = "";

            for (int i = 0; i < s1.Length; i++)
            {
                if (i == n)
                {
                    result += s2;
                }
                result += s1[i];
            }

            if (n == s1.Length)
            {
                result += s2;
            }

            return new string(result);
        }
        public static string Delete(string s, int n, int l)
        {

            char[] result = new char[s.Length - l];
            int index = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i < n || i >= n + l)
                {
                    result[index] = s[i];
                    index++;
                }
            }
            return new string(result);
        }

        public static string StrCSpn(string s, string s1)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(s1))
                return "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s1.Contains(s[i]))
                    return s.Substring(0, i); 
            }

            return s;
        }

        public static string Replace(string s, string s1, string s2)
        {
            string result = "";
            int i = 0;

            while (i < s.Length)
            {
                bool match = true;

                if (i + s1.Length <= s.Length)
                {
                    for (int j = 0; j < s1.Length; j++)
                    {
                        if (s[i + j] != s1[j])
                        {
                            match = false;
                            break;
                        }
                    }
                }
                else
                {
                    match = false;
                }

                if (match)
                {
                    result += s2;
                    i += s1.Length;
                }
                else
                {
                    result += s[i];
                    i++;
                }
            }
            return new string(result);
        }
    }
}
