public class Solution 
{
    public bool AreSentencesSimilar(string sentence1, string sentence2)
    {
        string[] words1 = sentence1.Split(" ");
        string[] words2 = sentence2.Split(" ");
        if (words1.Length < words2.Length)
        {
            var temp = words1;
            words1 = words2;
            words2 = temp;
        }

        int left = 0, right = 0;

        while (left < words2.Length && words1[left].Equals(words2[left]))
        {
            left++;
        }

        while (right < words2.Length && words1[words1.Length - 1 - right].Equals(words2[words2.Length - 1 - right]))
        {
            right++;
        }

        return left + right >= words2.Length;

    }
}