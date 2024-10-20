public class Solution
{
    public bool ParseBoolExpr(string expression)
    {
        var stack = new Stack<char>();
        foreach (var let in expression.ToCharArray())
        {
            if (let == ',' || let == '(')
            {
                continue;
            }

            if (let == 't' || let == 'f' || let == '!' || let == '&' || let == '|')
            {
                stack.Push(let);
            }
            else if (let == ')')
            {
                bool hasTrue = false;
                bool hasFalse = false;

                var topLet = stack.Peek();
                while (topLet != '!' && topLet != '&' && topLet != '|')
                {
                    stack.Pop();
                    if (topLet == 't')
                    {
                        hasTrue = true;
                    }
                    else if (topLet == 'f')
                    {
                        hasFalse = true;
                    }
                    topLet = stack.Peek();
                }
                var op = stack.Pop();
                if (op == '!')
                {
                    stack.Push(hasTrue ? 'f' : 't');
                }
                else if (op == '&')
                {
                    stack.Push(hasFalse ? 'f' : 't');
                }
                else if (op == '|')
                {
                    stack.Push(hasTrue ? 't' : 'f');
                }
            }
        }
        return stack.Peek() == 't';
    }
}