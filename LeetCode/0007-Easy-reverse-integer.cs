namespace LeetCode;

public partial class Problems
{
    public int Reverse(int x)
    {
        if (x == int.MinValue)
        {
            return 0;
        }

        var sum = 0;

        var v = Math.Abs(x);
        var v1 = v;
        List<int> digits = new List<int>();
        while (v1 > 0)
        {
            var d = v1 % 10;
            v1 = v1 / 10;
            digits.Add(d);
        }

        for (int i = 0; i < digits.Count; i++)
        {
            var c = digits[i];
            for (int j = 0; j < digits.Count - i - 1; j++)
            {
                c *= 10;
                if (c % 10 != 0)
                {
                    return 0;
                }
            }

            sum += c;
        }

        if (x < 0 && sum > 0)
        {
            return -sum;
        }

        if (x > 0 && sum < 0)
        {
            return 0;
        }

        var reversed = sum.ToString();
        var xx = new string(v.ToString().Reverse().ToArray()).ToString().TrimStart('0');
        if (string.Compare( reversed, xx) !=0)
        {
            return 0;
        }

        return sum;
    }
}
