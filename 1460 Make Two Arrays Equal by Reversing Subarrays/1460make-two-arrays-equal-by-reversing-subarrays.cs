public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        Dictionary<int, int> targetNums = new Dictionary<int, int>();
        foreach (int num in target)
        {
            if (!targetNums.ContainsKey(num))
            {
                targetNums.Add(num, 0);
            }
            targetNums[num]++;
        }

        foreach (int num in arr)
        {
            if (!targetNums.ContainsKey(num))
            {
                return false;
            }

            if (targetNums[num] == 0)
            {
                return false;
            }
            targetNums[num]--;
        }
        return true;
    }
}