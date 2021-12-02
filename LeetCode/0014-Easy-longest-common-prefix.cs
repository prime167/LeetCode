namespace LeetCode;

public partial class Problems
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1)
        {
            return strs[0];
        }

        var quit = false;
        var commonLen = 0;
        var len = strs.Min(s => s.Length);
        for (int i = 0; i < len; i++)
        {
            var ch0 = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                var str = strs[j];
                var ch = str[i];

                if (ch != ch0)
                {
                    quit = true;
                    break;
                }
            }

            if (quit)
            {
                break;
            }
            else
            {
                commonLen++;
            }
        }

        return strs[0].Substring(0, commonLen);
    }
}
