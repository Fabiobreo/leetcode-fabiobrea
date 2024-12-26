public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {
        return Find(nums,target,nums.Length-1,0);
    }

    int Find(int[] nums,int target,int l,int sum){
        if(l<0&sum!=target)
        return 0;
        if(l<0&&sum==target)
        return 1;
        int m1=Find(nums,target,l-1,sum+nums[l]);
        int m1t=m1==0?0:m1;
        int m2=Find(nums,target,l-1,sum-nums[l]);
        int m2t=m2==0?0:m2;
        return m1t+m2t;
    }
}