using System;
using static System.Console;

namespace cs_codingTest
{
    class Program
    {
        static void Main()
        {
            int[] solution(int n, string[] words)
            {
                int[] answer = { 0, 0 };

                for( int i = 0; i < words.Length; i++) // 중복단어 확인
                {
                    for( int j = i + 1; j < words.Length; j++)
                    {
                        if( words[i] == words[j])
                        {
                            answer[0] = j % n + 1;
                            answer[1] = j / n + 1;
                            break;
                        }

                    }
                }

                for (int i = 0; i < words.Length - 1; i++) // 끝말 이어지는지 확인
                {
                    string w1 = words[i];
                    string w2 = words[i + 1];

                    if (w1[words[i].Length - 1] != w2[0])
                    {
                        if (answer[0] > (i + 1) % n + 1 || answer[0] == 0) // 중복단어가 있을경우에 앞단어들이 끝말이 이어지는지를 확인
                        {
                            answer[0] = (i + 1) % n + 1;
                        }
                        if (answer[1] > (i + 1) / n + 1 || answer[1] == 0)
                        {
                            answer[1] = (i + 1) / n + 1;
                        }
                        break;
                    }
                }

                return answer;
            }
        }
    }
}
