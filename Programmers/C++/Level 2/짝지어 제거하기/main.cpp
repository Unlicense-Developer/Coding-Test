#include <iostream>
#include <string>
#include <stack>

using namespace std;

int solution(string s)
{
    int answer = -1;

    stack<char> check;

    for (int i = 0; i < s.size(); i++)
    {
        if (check.empty() || check.top() != s[i])
            check.push(s[i]);
        else if (check.top() == s[i])
            check.pop();
    }

    if (check.empty())
        answer = 1;
    else
        answer = 0;

    return answer;
}