public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var aux = "";
        var largestSubstring = "";
    
        for (int i = 0; i < s.Length; i++)
        {
        	var charIndex = aux.IndexOf(s[i]);
        	if (charIndex == -1)
        		aux += s[i];
        	else
        	{
        		if (largestSubstring.Length <= aux.Length)
        			largestSubstring = aux;
    
        		aux = aux.Substring(charIndex + 1);
        		aux += s[i];
        	}
    
        	if (i == s.Length - 1 && largestSubstring.Length <= aux.Length)
        		largestSubstring = aux;
        }
    
        return largestSubstring.Length;
    }
}