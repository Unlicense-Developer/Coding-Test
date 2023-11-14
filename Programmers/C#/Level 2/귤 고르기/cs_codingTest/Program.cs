using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace cs_codingTest
{
    class Program
    {
        static void Main()
        {
            int solution(int k, int[] tangerine)
            {
                int answer = 0;
                int count = 0;

                Dictionary<int, int> box = new Dictionary<int, int>();

                // 수량별 정리
                for (int i = 0; i < tangerine.Length; i++)
                {
                    if (box.ContainsKey(tangerine[i]))
                        box[tangerine[i]]++;
                    else
                        box.Add(tangerine[i], 1);
                }

                box = box.OrderByDescending(item => item.Value).ToDictionary(x => x.Key, x => x.Value);

                foreach (KeyValuePair<int, int> entry in box)
                {
                    count += entry.Value;

                    if (count >= k)
                    {
                        answer += 1;
                        break;
                    }

                    answer++;
                }

                return answer;
            }

            int[] test = { 1, 3, 2, 5, 4, 5, 2, 3 };
            int a = 6;

            WriteLine(solution(a, test));
        }
    }
}
