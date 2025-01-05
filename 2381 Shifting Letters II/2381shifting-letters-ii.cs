public class Solution
{
    public string ShiftingLetters(string s, int[][] shifts)
    {
        int n = s.Length;
        int[] diff = new int[n];

        // Populate the difference array
        foreach (var shift in shifts)
        {
            int start = shift[0];
            int end = shift[1];
            int direction = shift[2] == 1 ? 1 : -1;
            diff[start] += direction;
            if (end + 1 < n) diff[end + 1] -= direction;
        }

        // Compute the prefix sum
        for (int i = 1; i < n; i++)
        {
            diff[i] += diff[i - 1];
        }

        // Apply the shifts
        char[] result = s.ToCharArray();
        for (int i = 0; i < n; i++)
        {
            int shift = diff[i] % 26;
            if (shift < 0) shift += 26;
            result[i] = (char)('a' + (result[i] - 'a' + shift) % 26);
        }

        return new string(result);
    }
}