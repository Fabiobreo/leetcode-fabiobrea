public class Solution
{
    private Dictionary<string, List<int>> memo = new Dictionary<string, List<int>>();

    public IList<int> DiffWaysToCompute(string expression)
    {
        if (memo.ContainsKey(expression))
        {
            return memo[expression];
        }
        
        List<int> result = new List<int>();
        for (int i = 0; i < expression.Length; i++)
        {
            char c = expression[i];

            if (c == '+' || c == '-' || c == '*')
            {
                IList<int> left = DiffWaysToCompute(expression.Substring(0, i));
                IList<int> right = DiffWaysToCompute(expression.Substring(i + 1));
                foreach (int l in left)
                {
                    foreach (int r in right)
                    {
                        switch (c)
                        {
                            case '+':
                                result.Add(l + r);
                                break;
                            case '-':
                                result.Add(l - r);
                                break;
                            case '*':
                                result.Add(l * r);
                                break;
                        }
                    }
                }
            }
        }

        if (result.Count == 0)
        {
            result.Add(int.Parse(expression));
        }

        memo[expression] = result;

        return result;
    }
}