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
public class Solution {
    public TreeNode ReplaceValueInTree(TreeNode root) {
        if (root == null)
        {
            return root;
        }

        var nodeQueue = new Queue<TreeNode>();
        nodeQueue.Enqueue(root);
        var levelSums = new List<int>();

        // Sum all the levels, BFS
        while (nodeQueue.Count > 0)
        {
            int levelSum = 0;
            int levelSize = nodeQueue.Count;
            for (int i = 0; i < levelSize; ++i)
            {
                var currentNode = nodeQueue.Dequeue();
                levelSum += currentNode.val;
                if (currentNode.left != null)
                {
                    nodeQueue.Enqueue(currentNode.left);
                }

                if (currentNode.right != null)
                {
                    nodeQueue.Enqueue(currentNode.right);
                }
            }
            levelSums.Add(levelSum);
        }

        nodeQueue.Enqueue(root);
        int levelIndex = 1;
        root.val = 0;
        while (nodeQueue.Count > 0)
        {
            int levelSize = nodeQueue.Count;
            for (int i = 0; i < levelSize; ++i)
            {
                var currentNode = nodeQueue.Dequeue();
                int siblingSum = (currentNode.left != null ? currentNode.left.val : 0) + (currentNode.right != null ? currentNode.right.val : 0);
                if (currentNode.left != null)
                {
                    currentNode.left.val = levelSums[levelIndex] - siblingSum;
                    nodeQueue.Enqueue(currentNode.left);
                }
                
                if (currentNode.right != null)
                {
                    currentNode.right.val = levelSums[levelIndex] - siblingSum;
                    nodeQueue.Enqueue(currentNode.right);
                }
            }
            ++levelIndex;
        }
        return root;
    }
}