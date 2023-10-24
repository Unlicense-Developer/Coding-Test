#include <string>
#include <vector>

using namespace std;

int solution(vector<int> ingredient) {
    int answer = 0;

    string burger;

    for (int i : ingredient)
    {
        burger += to_string(i);

        if (burger.size() >= 4)
        {
            string temp = burger.substr(burger.size() - 4);

            if (temp == "1231")
            {
                answer++;
                burger = burger.substr(0, burger.size() - 4);
            }
        }
    }

    return answer;
}