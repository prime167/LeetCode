namespace LeetCode;

public partial class Problems
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        var digits = x.ToString().ToCharArray();

        var len = digits.Count();
        if (len == 1)
        {
            return true;
        }

        for (int i = 0; i < len; i++)
        {
            if (digits[i] != digits[len - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}
