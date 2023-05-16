#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int solution(int n, vector<int> lost, vector<int> reserve) {
    int answer = 0;
    vector<int> suit(n, 1);

    for (int l : lost)
        suit[l - 1]--;

    for (int r : reserve)
        suit[r - 1]++;

    for (int i = 0; i < n; i++)
    {
        if (!suit[i])
        {
            if (i && suit[i - 1] == 2)
            {
                suit[i - 1]--;
                suit[i]++;
            }
            else if (i != suit.size() - 1 && suit[i + 1] == 2)
            {
                suit[i + 1]--;
                suit[i]++;
            }
        }
    }

    for (int s : suit)
    {
        if (s != 0)
            answer++;
    }

    return answer;
}