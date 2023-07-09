namespace LeetCode.Medium;

public class M735
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        var stack = new Stack<int>();
        var resStack = new Stack<int>();

        foreach (var asteroid in asteroids)
        {
            stack.Push(asteroid);
        }

        resStack.Push(stack.Pop());

        while (stack.Count > 0)
        {
            var last = resStack.Pop();
            var next = stack.Pop();
            
            if (next > 0 && last < 0)
            {
                if (next > Math.Abs(last))
                {
                    stack.Push(next);
                    if (resStack.Count > 1)
                        stack.Push(resStack.Pop());
                }
                else if (next < Math.Abs(last))
                {
                    resStack.Push(last);
                }
                else
                {
                    if (stack.Count > 0 && resStack.Count == 0)
                        resStack.Push(stack.Pop());
                }
            }
            else
            {
                resStack.Push(last);
                resStack.Push(next);
            }
            
            if (resStack.Count == 0 && stack.Count > 0)
                resStack.Push(stack.Pop());
        }

        var res = new int[resStack.Count];
        var i = 0;
        
        while (resStack.Count > 0)
        {
            res[i] = resStack.Pop();
            i++;
        }
        
        return res;
    }
}