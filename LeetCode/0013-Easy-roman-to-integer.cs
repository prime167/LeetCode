namespace LeetCode;

public partial class Problems
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> dics = new Dictionary<char, int>();
        Dictionary<string, string> dics1 = new Dictionary<string, string>();
        dics.Add('I', 1);
        dics.Add('V', 5);
        dics.Add('X', 10);
        dics.Add('L', 50);
        dics.Add('C', 100);
        dics.Add('D', 500);
        dics.Add('M', 1000);

        dics.Add('a', 4);
        dics.Add('b', 9);
        dics.Add('c', 40);
        dics.Add('d', 90);
        dics.Add('e', 400);
        dics.Add('f', 900);

        dics1.Add("IV", "a");
        dics1.Add("IX", "b");
        dics1.Add("XL", "c");
        dics1.Add("XC", "d");
        dics1.Add("CD", "e");
        dics1.Add("CM", "f");

        string str1 = s;
        foreach (var kv in dics1)
        {
            str1 = str1.Replace(kv.Key, kv.Value);
        }

        var chars = str1.ToCharArray();
        int sum = 0;
        foreach (var c in chars)
        {
            var v = dics[c];
            sum += v;
        }

        return sum;
    }
}
