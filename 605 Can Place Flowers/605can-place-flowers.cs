public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        bool canPlace = true;
        for (int i = 0; i < flowerbed.Length - 1; ++i)
        {
            if (flowerbed[i] == 1)
            {
                canPlace = false;
            }
            else if (flowerbed[i] == 0 && !canPlace)
            {
                canPlace = true;
            }
            else if (flowerbed[i] == 0 && canPlace)
            {
                if (flowerbed[i + 1] == 0)
                {
                    n--;
                    canPlace = false;
                }
            }
        }

        if (canPlace && flowerbed[flowerbed.Length - 1] == 0)
        {
            n--;
        }
        return n <= 0;
    }
}