using System;
using static System.Console;

namespace cs_codingTest
{
    public class Program
    {
        static void Main()
        {
            int solution(int[] citations)
            {
                int answer = 0;
                int sum = 0;

                for( int i = 0; i < citations.Length; i++)
                {
                    sum += citations[i];
                }

                if(sum % citations.Length == 0)
                    answer = sum / citations.Length;
                else
                {
                    answer = sum / citations.Length;

                    for( int i = answer; i > 0; i--)
                    {
                        int count = 0;

                        for (int j = 0; j < citations.Length; j++)
                        {
                            if (i <= citations[j])
                                count++;
                        }

                        if (count >= i)
                        {
                            answer = i;
                            break;
                        }
                    }
                }

                return answer;
            }
        }
    }
}
