public class Solution {
        public double MaxAverageRatio(int[][] classes, int extraStudents) {
                PriorityQueue<(int p,int t),double> pq=new(classes.Select(c=>((c[0],c[1]), (double)c[0]/c[1]-(c[0]+1.0)/(c[1]+1))));
                        for(int i=0; i<extraStudents; i++) {
                                    var cl=pq.Peek();
                                                pq.DequeueEnqueue((cl.p+1,cl.t+1), (cl.p+1.0)/(cl.t+1)-(cl.p+2.0)/(cl.t+2));
                                                        }
                                                                return pq.UnorderedItems.Average(c=>(double)c.Item1.p/c.Item1.t);
                                                                    }
                                                                    
}