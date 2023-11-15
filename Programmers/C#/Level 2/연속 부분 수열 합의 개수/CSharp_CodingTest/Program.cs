using System;
using System.Collections.Generic;
using static System.Console;

namespace CSharp_CodingTest
{
    internal class Program
    {
        static void Main()
        {
            int solution(int[] elements)
            {
                int answer = 0;
                int[] elementSum = new int[elements.Length * 1000 + 1];

                // 숫자 길이별 체크
                for ( int length = 1; length <= elements.Length; length++ )
                {
                    for( int i = 0; i < elements.Length; i++)
                    {
                        int sum = 0;

                        for (int j = 0; j < length; j++)
                        {
                            sum += elements[(i + j) % (elements.Length)];
                        }

                        if(elementSum[sum] == 0)
                        {
                            elementSum[sum]++;
                            answer++;
                        }
                    }
                }
                

                return answer;
            }
        }
    }
}