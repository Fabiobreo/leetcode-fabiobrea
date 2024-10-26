public class Solution {
    public int PossibleStringCount(string word) {
        if (string.IsNullOrEmpty(word))
        {
            return 0;
        }

        int result = 1;
        int i = 0;
        while (i < word.Length)
        {
            var current = word[i];
            int count = 1;
            int j = i + 1;
            while (j < word.Length && word[j] == current)
            {
                count++;
                j++;
            }

            if (count >= 2)
            {
                result += count - 1;
            }
            i = j;
        }
        return result;
    }
}