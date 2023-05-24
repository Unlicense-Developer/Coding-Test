#include <iostream>

using namespace std;

int solution(int n)
{
    int ans = 0;

    while (n != 0)
    {
        if (n % 2 == 0)
            n /= 2;
        else if (n % 2 == 1)
        {
            n /= 2;
            ans++;
        }
    }

    return ans;
}