using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    public class ReverseWordsInAString3
    {
        public static string ReverseWords(string s)
        {
            var strings = s.Split(' ');
            var result = new string[strings.Length];
            var index = 0;
            foreach (var str in strings)
            {
                string tmp = "";
                for (int i = str.Length - 1; i >=0 ; i--)
                {
                    tmp = str[i] + tmp;
                }
                result[index++] = tmp;
            }
            
            return string.Join(" ", result);
        }
        public static string ReverseWords2(string s)
        {
            var result = new List<string>();
            foreach (var str in s.Split(' '))
            {
                string tmp = "";
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    tmp += str[i];
                }
                result.Add(tmp);
            }
            return string.Join(" ", result);
        }
        public static string ReverseWords3(string s)
        {
            var result = "";
            var left = -1;
            for (int right = 0; right < s.Length; right++)
            {
                if (s[right].ToString() == " ")
                {
                    result += Helper3(s, left, right) + " ";
                    left = right;
                }
                else if (right == s.Length - 1)
                {
                    result += Helper3(s, left, s.Length);
                }
            }
            return result;
        }
        public static string Helper3(string s, int left, int right)
        {
            var str = "";
            for (int i = right - 1; i > left; i--)
            {
                str += s[i];
            }
            return str;
        }
    }
}
