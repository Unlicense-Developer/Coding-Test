using System;
using static System.Console;

namespace cs_codingTest
{
    class Program
    {
        static void Main()
        {
            int solution(int n)
            {
                int nTemp = n;
                int answer = 0;

                while( answer == 0 )
                {
                    string nString = Convert.ToString(n, 2);
                    int nCount = 0;

                    for (int i = 0; i < nString.Length; i++)
                    {
                        if (nString[i] == '1')
                        {
                            nCount++;
                        }
                    }

                    nTemp++;

                    int oneCount = 0;
                    string temp = Convert.ToString(nTemp, 2);

                    for ( int i = 0; i < temp.Length; i++)
                    {
                        if( temp[i] == '1')
                        {
                            oneCount++;
                        }
                    }

                    if (oneCount == nCount)
                        answer = nTemp;
                }

                return answer;
            }
        }
    }
}
