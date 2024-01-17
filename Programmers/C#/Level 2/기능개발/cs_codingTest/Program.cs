using System;
using System.Collections.Generic;
using static System.Console;

namespace cs_codingTest
{
    public class Program
    {
        static void Main()
        {
            int[] solution(int n, long left, long right)
            {
                int[] answer = new int[right - left + 1];

                for( int i = 0; i < answer.Length; i++)
                {
                    int num = i + (int)left;

                    answer[i] = (num / n >= num % n) ? num / n : num % n;
                    answer[i] += 1;
                }

                return answer;
            }
        }
    }
}
