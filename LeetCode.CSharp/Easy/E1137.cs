namespace LeetCode.Easy;

public class E1137
{
    public int Tribonacci(int n)
    {
        List<int> numbers = new List<int> {0, 1, 1};

        if (n < 3)
            return numbers[n];

        for (int i = 3; i <= n; i++)
        {
            var sum = numbers[i - 1] + numbers[i - 2] + numbers[i - 3];
            numbers.Add(sum);
        }

        return numbers[^1];
    }
}