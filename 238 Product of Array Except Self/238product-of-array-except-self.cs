public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var result = new int[nums.Length];
        var prefixProduct = 1;
        for (int i = 0; i < nums.Length; ++i)
        {
            result[i] = prefixProduct;
            prefixProduct *= nums[i];
        }

        var suffixProduct = 1;
        for (int i = nums.Length - 1; i >= 0; --i)
        {
            result[i] *= suffixProduct;
            suffixProduct *= nums[i];
        }
        return result;
    }
}