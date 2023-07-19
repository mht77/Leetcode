namespace LeetCode.Medium;

public class M547
{
    public int FindCircleNum(int[][] isConnected)
    {
        var graph = new Dictionary<int, List<int>>();

        for (int i = 0; i < isConnected.Length; i++)
        {
            graph.Add(i, new List<int>());
            for (int j = 0; j < isConnected.Length; j++)
            {
                if (i == j)
                    continue;
                
                if (isConnected[i][j] == 0)
                    continue;
                
                graph[i].Add(j);
            }
        }

        var visited = new HashSet<int>();
        var province = new Stack<int>();
        var count = 0;
        
        foreach (var node in graph.Keys)
        {
            if (visited.Contains(node))
                continue;
            
            province.Push(node);
            
            while (province.Count > 0)
            {
                var next = province.Pop();

                foreach (var connectedNode in graph[next])
                {
                    if (!visited.Contains(connectedNode))
                        province.Push(connectedNode);
                }

                visited.Add(next);
            }

            count++;
        }
        
        return count;
    }
}