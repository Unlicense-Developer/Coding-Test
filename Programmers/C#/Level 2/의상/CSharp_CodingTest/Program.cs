using System;
using System.Collections.Generic;

namespace cs_codingTest
{
    public class Program
    {
        static void Main()
        {
            int solution(string[,] clothes)
            {
                int answer = 1;

                Dictionary<string, int> clothesCount = new Dictionary<string, int>();

                for (int i = 0; i < clothes.GetLength(0); i++)
                {
                    string type = clothes[i, 1]; // 옷 종류 string 
                    if(clothesCount.ContainsKey(type))
                    {
                        clothesCount[type]++;
                    }
                    else
                    {
                        clothesCount[type] = 1;
                    }
                }

                foreach ( int count in clothesCount.Values)
                {
                    answer *= ( count + 1 );
                }

                answer--;

                return answer;
            }
        }
    }
}