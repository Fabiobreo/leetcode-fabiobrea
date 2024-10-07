public class Solution
{
    public int MinLength(string s)
    {
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; ++i)
        {
            if (i == 0 || stack.Count() == 0)
            {
                stack.Push(s[i]);
                continue;
            }

            var topStack = stack.Peek();
            if ((s[i] == 'B' && topStack == 'A') || (s[i] == 'D' && topStack == 'C'))
            {
                stack.Pop();
            }
            else
            {
                stack.Push(s[i]);
            }
        }
        return stack.Count();
    }
}