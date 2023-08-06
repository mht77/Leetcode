namespace LeetCode.Medium;

public class M739
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var res = new int[temperatures.Length];
        Stack<(int, int)> stack = new Stack<(int, int)>();

        for (var index = 0; index < temperatures.Length; index++)
        {
            var temperature = temperatures[index];

            while (stack.Count > 0 && stack.Peek().Item1 < temperature)
            {
                var (_, i) = stack.Pop();
                res[i] = index - i;
            }

            stack.Push((temperature, index));
        }
        
        return res;
    }
}