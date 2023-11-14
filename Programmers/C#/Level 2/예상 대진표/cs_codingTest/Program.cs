using System;
using static System.Console;

namespace cs_codingTest
{
    class Program
    {
        static void Main()
        {
            int solution(int n, int a, int b)
            {
                int answer = 1;

                for( int i = 1; i < n / 2; i++)
                {
                    // 바로 만나는 케이스
                    if( a % 2 == 0 && a - 1 == b)
                        break;
                    if (a % 2 != 0 && a + 1 == b)
                        break;

                    //a, b 라운드 진출 계산
                    if (a % 2 == 0)
                        a /= 2;
                    else
                        a = a / 2 + 1;

                    if (b % 2 == 0)
                        b /= 2;
                    else
                        b = b / 2 + 1;

                    answer++;
                }
                

                return answer;
            }
        }
    }
}
