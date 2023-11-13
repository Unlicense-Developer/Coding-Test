using System;
using static System.Console;

namespace cs_codingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] solution(string s)
            {
                int[] answer = new int[2];
                int binCount = 0;
                int zeroCount = 0;
                int oneCount = 0;

                while( s.Length != 1)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == '0')
                            zeroCount++;
                        else if (s[i] == '1')
                            oneCount++;
                    }

                    s = Convert.ToString(oneCount, 2);
                    binCount++;
                    oneCount = 0;
                }

                answer[0] = binCount;
                answer[1] = zeroCount;

                return answer;
            }
        }
    }
}
