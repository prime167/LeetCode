namespace LeetCode;

public partial class Problems
{
    public bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return false;
        }

        var chars = s.ToCharArray();
        Stack<char> stack = new Stack<char>();
        foreach (var ch in chars)
        {
            if (ch == '[' || ch == '{' || ch == '(')
            {
                stack.Push(ch);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                var ch1 = stack.Pop();
                if (ch1 == '[' && ch == ']' || ch1 == '(' && ch == ')' || ch1 == '{' && ch == '}')
                {

                }
                else
                {
                    return false;
                }
            }
        }

        if (stack.Count == 0)
        {
            return true;
        }
        return false;
    }
}
