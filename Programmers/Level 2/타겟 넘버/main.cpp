#include <vector>
#include <string>

using namespace std;

int answer = 0;

void CheckTargetNumber(vector<int> numbers, int target, int sum, int index)
{

    if (index == numbers.size())
    {
        if (sum == target)
            answer++;

        return;
    }

    CheckTargetNumber(numbers, target, sum + numbers[index], index + 1);
    CheckTargetNumber(numbers, target, sum - numbers[index], index + 1);

}

int solution(vector<int> numbers, int target)
{
    CheckTargetNumber(numbers, target, 0, 0);

    return answer;
}