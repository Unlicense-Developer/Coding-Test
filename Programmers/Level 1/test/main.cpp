#include <string>
#include <vector>

using namespace std;

bool solution(int x) {
    bool answer = true;

    int harshad = x;
    int sum = 0;

    sum += harshad / 10000;
    harshad %= 10000;
    sum += harshad / 1000;
    harshad %= 1000;
    sum += harshad / 100;
    harshad %= 100;
    sum += harshad / 10;
    harshad %= 10;
    sum += harshad / 1;
    harshad %= 1;

    if (x % sum == 0)
        answer = true;
    else
        answer = false;

    return answer;
}