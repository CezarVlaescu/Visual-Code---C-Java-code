class Problem
{
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
    
    public class Solution 
    {
        private List<int> nodes = new List<int>();
        public IList<int> InorderTransversal(TreeNode root)
        {
        
            if(root == null)
            {
                return new List<int>();
            }
            if(root.left == null)
            {
                return new List<int>{val.root};
            }
            TravelTheRoot(root);
            return nodes;
         }
    
    
         private void TravelTheRoot(TreeNode node)
         {   
            if(node == null) return;
            TravelTheRoot(node.left);
            TravelTheRoot(node.right);
            nodes.Add(node.val);
         }
     }
}
