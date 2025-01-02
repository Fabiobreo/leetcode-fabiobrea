public class Solution {
        public int[] VowelStrings(string[] words, int[][] queries) {
                    var n = words.Length;
                                var isValidArr = new int[n + 1];

                                            for (var i = 1; i <= n; i++)
                                                        {
                                                                        var strLen = words[i - 1].Length;
                                                                                        isValidArr[i] = isValidArr[i - 1];
                                                                                                        if (IsVowel(words[i - 1][0]) && IsVowel(words[i - 1][strLen - 1]))
                                                                                                                        {
                                                                                                                                            isValidArr[i] += 1;
                                                                                                                                                            }
                                                                                                                                                                        }

                                                                                                                                                                                    var queryLen = queries.Length;
                                                                                                                                                                                                var ans = new int[queryLen];
                                                                                                                                                                                                            for (var i = 0; i < queryLen; i++)
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                        var l = queries[i][0];
                                                                                                                                                                                                                                                        var r = queries[i][1];

                                                                                                                                                                                                                                                                        ans[i] = isValidArr[r + 1] - isValidArr[l];
                                                                                                                                                                                                                                                                                    }

                                                                                                                                                                                                                                                                                                return ans;
                                                                                                                                                                                                                                                                                                    }

                                                                                                                                                                                                                                                                                                        private bool IsVowel(char c)
                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                    return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                        }
