namespace LeetCode.Medium;

public class M1466
{
    public int MinReorder(int n, int[][] connections)
    {
        var graph = new Dictionary<int, List<(int, bool)>>();
        var visited = new HashSet<int>();
        var count = 0;
        foreach (var connection in connections)
        {
            if (!graph.ContainsKey(connection[0]))
            {
                graph[connection[0]] = new List<(int, bool)>();
            }
            graph[connection[0]].Add((connection[1], true));
            if (!graph.ContainsKey(connection[1]))
            {
                graph[connection[1]] = new List<(int, bool)>();
            }
            graph[connection[1]].Add((connection[0], false));
        }

        DFS(graph, visited, 0, ref count);
        return count;
    }
    
    private void DFS(Dictionary<int, List<(int, bool)>> graph, HashSet<int> visited, int node, ref int count)
    {
        visited.Add(node);
        foreach (var (next, isReversed) in graph[node])
        {
            if (!visited.Contains(next))
            {
                if (isReversed)
                {
                    count++;
                }
                DFS(graph, visited, next, ref count);
            }
        }
    }
}