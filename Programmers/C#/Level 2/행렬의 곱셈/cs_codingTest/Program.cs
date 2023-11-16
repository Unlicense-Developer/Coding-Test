using System;
using static System.Console;

namespace cs_codingTest
{
    public class Program
    {
        static void Main()
        {
            int[,] solution(int[,] arr1, int[,] arr2)
            {
                int[,] answer = new int[arr1.GetLength(0), arr2.GetLength(1)]; ;
                
                //행
                for( int i = 0; i < answer.GetLength(0); i++)
                {
                    //열
                    for( int j = 0; j < answer.GetLength(1); j++)
                    {
                        int count = 0;

                        while( count < arr2.GetLength(0))
                        {
                            answer[i, j] += arr1[i, count] * arr2[count, j];
                            count++;
                        }
                    }
                }
                
                return answer;
            }
        }
    }
}
