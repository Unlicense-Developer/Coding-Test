using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace cs_codingTest
{
    public class Program
    {
        static void Main()
        {
            int solution(string s)
            {
                int answer = 0;

                //회전수만큼 체크
                for( int i = 0; i < s.Length; i++)
                {
                    answer += CheckBracket(s) ? 1 : 0;

                    //회전
                    s += s[0];
                    s = s.Remove(0, 1);
                }

                return answer;
            }

            bool CheckBracket(string s)
            {
                string open = "({[";
                string close = ")}]";
                string temp = "";

                for( int i = 0; i < s.Length; i++)
                {
                    // 여는 괄호일때
                    if (open.Contains(s[i]))
                        temp += s[i];
                    else // 닫는 괄호일때
                    {
                        // 처음부터 닫는괄호일때
                        if (temp.Length == 0) 
                            return false;
                        // temp 맨뒤 char이 현재 들어오는 괄호와 세트인지 체크
                        if (s[i] != close[open.IndexOf(temp[temp.Length - 1])])
                                return false;
                        // 위를 모두 통과하면 세트를 제거
                        temp = temp.Remove(temp.Length - 1, 1);
                    }
                }

                if (temp.Length != 0)
                    return false;

                return true;
            }
        }
    }
}
