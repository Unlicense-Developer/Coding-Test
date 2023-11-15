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
            int solution(string[] want, int[] number, string[] discount)
            {
                int answer = 0;
                Dictionary<string, int> dict = new Dictionary<string, int>();

                //딕셔너리 저장
                for( int i = 0; i < want.Length; i++)
                {
                    dict[want[i]] = number[i];
                }

                //첫째날 방문 먼저 계산
                answer = CheckDiscount(dict, discount);

                //첫째날 계산결과를 토대로 첫날 할인품목을 빼주고 다음날 할인품목을 추가해줌
                //위에서 최초 계산한 딕셔너리의 값에서 할인품목을 더하면서 체크했기 때문에 
                //품목을 뺄때는 딕셔너리의 Value 증가, 더할땐 감소해야함
                //want는 10개로 고정되어있기 때문에, discount에서 10을 뺀만큼 품목을 증감하면서 검사
                for (int i = 0; i < discount.Length - 10; i++)
                {

                    if (dict.ContainsKey(discount[i]))
                    {
                        dict[discount[i]]++;
                    }
                    if (dict.ContainsKey(discount[i + 10]))
                    {
                        dict[discount[i + 10]]--;
                    }

                    //dict value 0인지체크
                    if (CheckNumber(dict))
                    {
                        answer++;
                    }
                }

                return answer;
            }

            int CheckDiscount( Dictionary<string, int> dict, string[] discount)
            {
                int answer = 0;

                //discount 품목 검사
                for (int i = 0; i < 10; i++)
                {
                    if (dict.ContainsKey(discount[i]))
                        dict[discount[i]]--;
                }

                if (CheckNumber(dict))
                    answer++;

                return answer;
            }

            // 딕셔너리가 비어있는지 체크
            bool CheckNumber( Dictionary<string, int> dict)
            {
                foreach (int i in dict.Values)
                {
                    if (i != 0)
                        return false;
                }

                return true;
            }
        }
    }
}
