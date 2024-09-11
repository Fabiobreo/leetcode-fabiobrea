public class Solution
{
    public int MinBitFlips(int start, int goal)
    {
        int z = start ^ goal;

        int cnt = 0;
        while(z != 0){
            cnt++;
            z = z & z-1;
        }
        return cnt;
    }
}