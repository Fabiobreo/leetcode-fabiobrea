public class Solution
{
    public string AddBinary(string a, string b)
    {
        var resultBuilder = new StringBuilder();
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carriage = 0;

        for (; i >= 0 || j >= 0; i--, j--)
        {
            carriage += (i >= 0 ? a[i] - 48 : 0);
            carriage += (j >= 0 ? b[j] - 48 : 0);
            resultBuilder.Insert(0, carriage % 2);
            carriage = carriage / 2;
        }

        if (carriage > 0)
        {
            resultBuilder.Insert(0, carriage);
        }

        return resultBuilder.ToString();
    }
}