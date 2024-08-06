public class Solution {
    public int MinimumPushes(string word) {
        Dictionary<char, int> frequency = new Dictionary<char, int>();
        foreach (char letter in word)
        {
            if (!frequency.ContainsKey(letter))
            {
                frequency.Add(letter, 0);
            }
            frequency[letter]++;
        }
        var sortedList = frequency.OrderByDescending(pair => pair.Value).ToList();
        for (int i = 0; i < sortedList.Count; ++i)
        {
            frequency[sortedList[i].Key] = (i / 8) + 1;
        }
        
        int result = 0;
        foreach (char letter in word)
        {
            result += frequency[letter];
        }
        return result;
    }
}