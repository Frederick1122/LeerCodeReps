using System;

namespace LeetCode880 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DecodeAtIndex("y959q969u3hb22odq595", 222280369));
        }
        
        public static string DecodeAtIndex(string s, int k)
        {
            long length = 0;
            int i = 0;

            while (length < k) {
                if (char.IsDigit(s[i])) {
                    length *= s[i] - '0';
                } else {
                    length++;
                }
                i++;
            }

            for (int j = i - 1; j >= 0; j--) {
                if (char.IsDigit(s[j])) {
                    length /= s[j] - '0';
                    k %= (int)length;
                } else {
                    if (k == 0 || k == length) {
                        return s[j].ToString();
                    }
                    length--;
                }
            }

            return "";
        }
    }
}