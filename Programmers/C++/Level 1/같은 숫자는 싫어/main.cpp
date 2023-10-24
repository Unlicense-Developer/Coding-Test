#include <vector>
#include <iostream>

using namespace std;

vector<int> solution(vector<int> arr)
{
    vector<int> answer;
    int tempNum = 0;

    for (int i = 0; i < arr.size(); i++)
    {
        if (i == 0)
        {
            tempNum = arr[i];
            answer.push_back(tempNum);
        }
        else
        {
            if (tempNum != arr[i])
            {
                tempNum = arr[i];
                answer.push_back(tempNum);
            }
        }
    }

    return answer;
}