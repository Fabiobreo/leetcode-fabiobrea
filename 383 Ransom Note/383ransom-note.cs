public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var frequency = new Dictionary<char, int>();
        foreach (var letter in magazine)
        {
            if (!frequency.ContainsKey(letter))
            {
                frequency.Add(letter, 0);
            }
            frequency[letter]++;
        }

        foreach (var letter in ransomNote)
        {
            if (!frequency.ContainsKey(letter) || frequency[letter] == 0)
            {
                return false;
            }
            frequency[letter]--;
        }
        return true;
    }
}