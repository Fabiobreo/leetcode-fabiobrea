public class Solution {
    public string LongestPalindrome(string s)
    {
        StringBuilder processedStr = new StringBuilder("^#");
        foreach (char c in s)
        {
            processedStr.Append(c).Append("#");
        }
        processedStr.Append("$");
        string modifiedString = processedStr.ToString();

        int strLength = modifiedString.Length;
        int[] palindromeLengths = new int[strLength];
        int center = 0;
        int rightEdge = 0;

        for (int i = 1; i < strLength - 1; i++)
        {
            palindromeLengths[i] = (rightEdge > i) ? Math.Min(rightEdge - i, palindromeLengths[2 * center - i]) : 0;
            while (modifiedString[i + 1 + palindromeLengths[i]] == modifiedString[i - 1 - palindromeLengths[i]])
            {
                palindromeLengths[i]++;
            }

            if (i + palindromeLengths[i] > rightEdge)
            {
                center = i;
                rightEdge = i + palindromeLengths[i];
            }
        }

        int maxLength = 0;
        int maxCenter = 0;
        for (int i = 0; i < strLength; i++)
        {
            if (palindromeLengths[i] > maxLength)
            {
                maxLength = palindromeLengths[i];
                maxCenter = i;
            }
        }

        int start = (maxCenter - maxLength) / 2;
        int end = start + maxLength;

        return s.Substring(start, end - start);
    }
}