namespace LeetCode.Easy;

public class E13
{
    private static readonly Dictionary<char, int> Romans = new Dictionary<char, int>(){
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},
    };
	    
    public int RomanToInt(string s) {
        return Calculate(s);
    }
	    
    private static int Calculate(string s){
        int res = 0;
        for (int i=0; i<s.Length;i++){
            if (i+1 == s.Length)
                res += Romans[s[i]];
            else if (Romans[s[i]] < Romans[s[i+1]]){
                res += Romans[s[i+1]] - Romans[s[i]];
                i++;
            }
            else
                res += Romans[s[i]];
        }
        return res;
    }
}