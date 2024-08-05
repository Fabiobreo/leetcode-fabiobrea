public class Solution {
    public string KthDistinct(string[] arr, int k) {
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        foreach (string word in arr)
        {
            if (!frequency.ContainsKey(word))
            {
                frequency.Add(word, 0);
            }
            frequency[word]++;
        }

        foreach (string word in arr)
        {
            if (frequency[word] == 1)
            {
                k--;
            }

            if (k == 0)
            {
                return word;
            }
        }
        return string.Empty;
    }
}