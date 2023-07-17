using System;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class BinaryTreePathSum
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
            return false;

        if (root.left == null && root.right == null)
            return root.val == targetSum;

        int remainingSum = targetSum - root.val;
        return HasPathSum(root.left, remainingSum) || HasPathSum(root.right, remainingSum);
    }
}

class Program
{
    static void Main()
    {
        TreeNode root = new TreeNode(5);
        root.left = new TreeNode(4);
        root.right = new TreeNode(8);
        root.left.left = new TreeNode(11);
        root.right.left = new TreeNode(13);
        root.right.right = new TreeNode(4);
        root.left.left.left = new TreeNode(7);
        root.left.left.right = new TreeNode(2);
        root.right.right.right = new TreeNode(1);

        int targetSum = 22;

        BinaryTreePathSum solution = new BinaryTreePathSum();
        bool hasPathSum = solution.HasPathSum(root, targetSum);

        Console.WriteLine($"Does the tree have a root to leaf path with sum {targetSum}? {hasPathSum}");
    }
}
