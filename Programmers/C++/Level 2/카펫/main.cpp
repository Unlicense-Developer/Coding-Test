#include <string>
#include <vector>

using namespace std;

vector<int> solution(int brown, int yellow) {
    vector<int> answer;

    int tile = brown + yellow;

    for (int w = tile; w > 0; w--)
    {
        int height = 0;

        if (tile % w == 0)
        {
            height = tile / w;

            if ((w - 2) * (height - 2) == yellow)
            {
                answer.push_back(w);
                answer.push_back(height);
                break;
            }

        }
    }


    return answer;
}