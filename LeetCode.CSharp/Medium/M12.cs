namespace LeetCode.Medium;

public class M12
{
    public string IntToRoman(int num)
    {
        string res = "";
        for (int i = 0; i < num / 1000; i++)
        {
            res += 'M';
        }
        
        num %= 1000;
        if (num >= 900)
        {
            res += "CM";
            num %= 900;
        }
        else
        {
            for (int i = 0; i < num / 500; i++)
            {
                res += 'D';
            }

            num %= 500;    
        }

        if (num >= 400)
        {
            res += "CD";
            num %= 400;
        }
        else
        {
            for (int i = 0; i < num / 100; i++)
            {
                res += 'C';
            }

            num %= 100;
        }

        if (num >= 90)
        {
            res += "XC";
            num %= 90;
        }
        else
        {
            for (int i = 0; i < num / 50; i++)
            {
                res += 'L';
            }

            num %= 50;
        }

        if (num >= 40)
        {
            res += "XL";
            num %= 40;
        }
        else
        {
            for (int i = 0; i < num / 10; i++)
            {
                res += 'X';
            }

            num %= 10;
        }

        if (num == 4)
            res += "IV";
        else if (num == 9)
            res += "IX";
        else
        {
            for (int i = 0; i < num/5; i++)
            {
                res += 'V';
            }

            num %= 5;
            for (int i = 0; i < num; i++)
            {
                res += 'I';
            }    
        }
        
        return res;
    }
}