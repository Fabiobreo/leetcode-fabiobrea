public class Solution {
        public int MincostTickets(int[] days, int[] costs) {
                int maxDay = 365;

                        bool[] isTravelDay = new bool[maxDay + 1];
                                foreach (int day in days) {
                                            isTravelDay[day] = true;
                                                    }

                                                            int[] dp = new int[maxDay + 1];
                                                                    dp[0] = 0; 
                                                                            for (int i = 1; i <= maxDay; i++) {
                                                                                        if (!isTravelDay[i]) {
                                                                                                        dp[i] = dp[i - 1];
                                                                                                                    } else {
                                                                                                                                    int cost1 = dp[i - 1] + costs[0]; 
                                                                                                                                                    int cost7 = dp[Math.Max(0, i - 7)] + costs[1]; 
                                                                                                                                                                    int cost30 = dp[Math.Max(0, i - 30)] + costs[2]; 
                                                                                                                                                                                    dp[i] = Math.Min(cost1, Math.Min(cost7, cost30));
                                                                                                                                                                                                }
                                                                                                                                                                                                        }
                                                                                                                                                                                                                return dp[maxDay];
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                    }


        

