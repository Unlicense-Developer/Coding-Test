using System;
using static System.Console;

namespace cs_codingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            public bool solution(string s)
            {
                bool answer = true;
                int count = 0;

                for( int i = 0; i < s.Length; i++)
                {
                    if( i == 0 && s[i] == ')')
                    {
                        answer = false;
                        break;
                    }    

                    if( s[i] == '(')
                    {
                        count++;
                    }
                    else if (s[i] == ')')
                    {
                        count--;

                        if( count < 0)
                        {
                            answer = false;
                            break;
                        }    
                    }

                    if (i == s.Length - 1 && count != 0)
                        answer = false;
                }

                return answer;
            }
        }

    
    }
}
