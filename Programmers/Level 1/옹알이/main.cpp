#include <string>
#include <vector>

using namespace std;

int solution(vector<string> babbling) {
    int answer = 0;

    for (string bab : babbling)
    {
        string check;
        string before;

        for (int i = 0; i < bab.size(); i++)
        {
            check += bab[i];

            if (check == "aya" ||
                check == "ye" ||
                check == "woo" ||
                check == "ma")
            {
                if (check == before) 
                    break;

                before = check;
                check.clear();
            }
        }

        if (check == "")
            answer++;
    }

    return answer;
}

int main()
{
    vector<string> babbling = { "ayaye", "uuu", "yeye", "yemawoo", "ayaayaa" };

    solution(babbling);
}