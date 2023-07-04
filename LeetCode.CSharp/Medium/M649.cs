namespace LeetCode.Medium;

public class M649
{
    public string PredictPartyVictory(string senate)
    {
        Queue<string> queue = new Queue<string>();
        
        foreach (var senator in senate)
        {
            if (senator == 'R')
                queue.Enqueue(senator.ToString());
            else
                queue.Enqueue(senator.ToString());
        }
        
        int dSkip = 0;
        int rSkip = 0;

        while (queue.Count > 1)
        {
            var senator = queue.Dequeue();

            if (senator == "R")
            {
                if (rSkip > 0)
                    rSkip--;
                else
                {
                    queue.Enqueue(senator);
                    dSkip++;
                }
            }
            else
            {
                if (dSkip > 0)
                    dSkip--;
                else
                {
                    queue.Enqueue(senator);
                    rSkip++;
                }
            }
            if (dSkip == queue.Count || rSkip == queue.Count)
                break;
        }
        
        return queue.Peek() == "R" ? "Radiant" : "Dire";
    }
}