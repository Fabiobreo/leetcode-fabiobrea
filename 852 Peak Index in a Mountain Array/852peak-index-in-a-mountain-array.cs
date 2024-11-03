public class Solution
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        var left = 0;
        var right = arr.Length - 1;
        while (left < right)
        {
            var distance = (right - left) / 3;
            var mid1 = left + distance;
            var mid2 = right - distance;

            if (arr[mid1] < arr[mid2])
            {
                left = mid1 + 1;
            }
            else if (arr[mid1] > arr[mid2])
            {
                right = mid2 - 1;
            }
            else
            {
                left = mid1 + 1;
                right = mid2 - 1;
            }
        }
        return left;
    }
}