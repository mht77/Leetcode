namespace LeetCode.Medium;

public class M2300
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        var pairs = new int[spells.Length];
        
        Array.Sort(potions);

        for (var i = 0; i < spells.Length; i++)
        {
            long spell = spells[i];
            int end = potions.Length - 1;
            int start = 0;
            int index = (end + start) / 2;
            bool found = false;

            while (true)
            {
                if (index == 0)
                {
                    if (potions.Length == 1)
                    {
                        if (potions[index] * spell >= success)
                            found = true;
                    }
                    else if (potions[index+1] * spell >= success)
                    {
                        if (potions[index] * spell < success)
                            index++;
                        found = true;
                    }
                    break;
                }
                
                if (potions[index-1] * spell < success && potions[index] * spell >= success)
                {
                    found = true;
                    break;
                }

                if (potions[index - 1] * spell >= success && potions[index] * spell >= success)
                    end = index;

                if (potions[index - 1] * spell < success && potions[index] * spell < success)
                    start = index;

                var oldIndex = index;
                index = (end + start) / 2;
                
                if (oldIndex == index)
                {
                    if (index + 1 == potions.Length - 1)
                        if (potions[index + 1] * spell >= success)
                        {
                            index++;
                            found = true;
                        }
                    break;
                }
            }

            if (found)
                pairs[i] = potions.Length - index;
        }

        return pairs;
    }
}