using System.Text;

namespace LeetCode.Medium;

public class M43
{
    public string Multiply(string num1, string num2) 
    {
        if (num1 == "0" || num2 == "0")
            return "0";
        
        List<int> digits = [];
        
        for (int i = 0; i < num1.Length; i++)
        {
            var d1 = int.Parse(num1[num1.Length - 1 - i].ToString());

            for (int j = 0; j < num2.Length ; j++)
            {
                var d2 = int.Parse(num2[num2.Length - 1 - j].ToString());

                var d = d1 * d2;

                if (digits.Count > i + j)
                {
                    digits[i+j] += d % 10;

                    var nxtDigit = digits[i + j] / 10 + d / 10;

                    if (digits.Count > i + j + 1)
                    {
                        digits[i + j + 1] += nxtDigit;
                    }
                    else
                    {
                        if (nxtDigit != 0)
                            digits.Add(nxtDigit);
                    }
                    
                    digits[i+j] %= 10;
                }
                else
                {
                    digits.Add(d%10);
                    
                    if (d/10 != 0)
                        digits.Add(d/10);
                }
            }
        }

        StringBuilder result = new StringBuilder();

        for (var i = 0; i < digits.Count; i++)
        {
            var t = digits[i];
            result.Insert(0, t);
        }

        return result.ToString();
    }
}