public class Solution {
    public bool IsValid(string s) {
        Stack<char> openPar = new Stack<char>();
        foreach (char par in s)
        {
            if (par == '(' || par == '[' || par == '{')
            {
                openPar.Push(par);
                continue;
            }

            if (openPar.Count == 0)
            {
                return false;
            }

            char peeked = openPar.Peek();
            if (par == ')' && peeked != '(' ||
                par == ']' && peeked != '[' ||
                par == '}' && peeked != '{')
            {
                return false;
            }

            openPar.Pop();
        }
        return openPar.Count == 0;
    }
}