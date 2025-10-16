public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> map = new Dictionary<char, int>()
        {
            
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
        };
        int intVal = 0;
        int previous = int.MaxValue;
        for (int i = 0; i < s.Length; ++i)
        {
            int current = map[s[i]];
            if (current > previous)
            {
                intVal -= 2 * previous;
            }
            previous = current;
            intVal += current;
        }
        return intVal;
    }
}