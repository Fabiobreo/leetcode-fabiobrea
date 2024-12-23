/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public int MinimumOperations(TreeNode root)
    {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int res=0;
        while(queue.Count>0){
            var len = queue.Count;
            var list = new List<int>();
            for(int i=0;i<len;i++){
                var node = queue.Dequeue();
                list.Add(node.val);
                if(node.left!=null)
                    queue.Enqueue(node.left);
                if(node.right!=null)
                    queue.Enqueue(node.right);
                
            }
            res += GetSwapCount(list);
        }
        return res;

        int GetSwapCount(List<int> list){
            var swaps = 0;
            var sorted = list.ToArray();
            Array.Sort(sorted);
            var map = new Dictionary<int,int>();
            
            for(int i=0;i<list.Count;i++){
                map.Add(list[i],i);
            }
            for(int i=0;i<list.Count;i++){
                if(sorted[i]!=list[i]){
                    swaps++;
                    map[list[i]] = map[sorted[i]];
                    list[map[sorted[i]]] = list[i];
                }
            }
            return swaps;
        }
    }
}