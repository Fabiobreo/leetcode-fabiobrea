public class Solution {
    public bool ValidMountainArray(int[] arr) {
        int N = arr.Length;

        if(arr.Length < 3)
            return false;
        // Find maximum
        int i = 0;

        while(i + 1 < N && arr[i] < arr[i+1])
            i++;

        if(i == 0 || i == N-1)            
            return false;

        while(i+1 < N && arr[i] > arr[i+1])
            i++;

        return i == N-1;
    }
}