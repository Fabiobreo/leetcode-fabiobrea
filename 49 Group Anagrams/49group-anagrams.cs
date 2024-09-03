public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        List<IList<string>> group = new List<IList<string>>();
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        foreach (var word in strs)
        {
            char[] charArray = word.ToCharArray();
            Array.Sort(charArray);
            string sortedString = new string(charArray);
            if (!map.ContainsKey(sortedString))
            {
                map.Add(sortedString, new List<string>());
            }
            map[sortedString].Add(word);
        }

        foreach (var pair in map)
        {
            group.Add(pair.Value);
        }
        return group;
    }
}