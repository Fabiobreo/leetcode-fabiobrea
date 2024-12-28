public class Solution {
        public int[] MaxSumOfThreeSubarrays(int[] nums, int k) {
                int n=nums.Length;
                        int[] sums = new int[n];

                                for(int i=0; i<k; i++){
                                            sums[0] += nums[i];
                                                    }

                                                            for(int i=k; i<n; i++){
                                                                        sums[i-k+1] = sums[i-k] - nums[i-k] + nums[i];
                                                                                }

                                                                                        int maxSum = 0;
                                                                                                int[] res = new int[3];
                                                                                                        int[][] dp = new int[n][];

                                                                                                                for(int i=0; i<n; i++){
                                                                                                                            dp[i] = new int[3];

                                                                                                                                        for(int j=i+k; j<n; j++){
                                                                                                                                                        int sum = sums[i] + sums[j];

                                                                                                                                                                        if(sum > dp[i][0]){
                                                                                                                                                                                            dp[i][0] = sum; 
                                                                                                                                                                                                                dp[i][1] = i; 
                                                                                                                                                                                                                                    dp[i][2] = j; 
                                                                                                                                                                                                                                                    }    
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                        }

                                                                                                                                                                                                                                                                                for(int i=0; i<n; i++){
                                                                                                                                                                                                                                                                                            for(int j=i+k; j<n; j++){
                                                                                                                                                                                                                                                                                                            int sum = sums[i] + dp[j][0];

                                                                                                                                                                                                                                                                                                                            if(sum > maxSum){
                                                                                                                                                                                                                                                                                                                                                maxSum = sum;
                                                                                                                                                                                                                                                                                                                                                                    res[0] = i;
                                                                                                                                                                                                                                                                                                                                                                                        res[1] = dp[j][1];
                                                                                                                                                                                                                                                                                                                                                                                                            res[2] = dp[j][2];
                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                }

                                                                                                                                                                                                                                                                                                                                                                                                                                                        return res;
                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                            }




