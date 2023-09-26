using System;

namespace LeetCode389 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheDifference("", "y"));
        }
        
        public static char FindTheDifference(string s, string t)
        {
            var dict = new Dictionary<char, int>();
            foreach (var key in s)
            {
                if (dict.ContainsKey(key))
                    dict[key]++;
                else
                    dict.Add(key, 1);
            }

            var answer = '\0';
            foreach (var key in t)
            {
                if (dict.ContainsKey(key))
                {
                    if(dict[key] == 0)
                    {
                        answer = key;
                        break;
                    }

                    dict[key]--;
                }
                else
                {
                    answer = key;
                    break;
                }
            }
            
            return answer;
        }
    }
}