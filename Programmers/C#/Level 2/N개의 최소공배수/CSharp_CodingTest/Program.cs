using System;
using static System.Console;

namespace CSharp_CodingTest
{
    internal class Program
    {
        static void Main()
        {
            int solution(int[] arr)
            {
                int answer = 0;
                int lcm = 0;

                for ( int i = 0; i < arr.Length - 1; i++)
                {
                    if( i == 0)
                        answer = ( arr[i] * arr[ i + 1] ) / GCD(arr[i], arr[i + 1]);
                    else
                        answer = (answer * arr[i + 1]) / GCD(answer, arr[i + 1]);
                }

                return answer;
            }

            int GCD(int a, int b)
            {
                int temp = 0;

                while (a != 0)
                {
                    temp = b % a;
                    b = a;
                    a = temp;
                }

                return b;
            }

            int[] a = { 2, 6, 8, 14 };

            WriteLine(solution(a));
        }
    }
}