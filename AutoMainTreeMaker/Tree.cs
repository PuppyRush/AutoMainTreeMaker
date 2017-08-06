using System.Collections.Generic;

using System;

namespace AutoMainTreeMaker
{
    
    public class Tree
    {
        //ColumnSequence가 키.
        private Dictionary<int, List<TreeNode>> tree;

        public Tree()
        {
 
            TreeMap = new Dictionary<int, List<TreeNode>>();
        }

        internal Dictionary<int, List<TreeNode>> TreeMap
        {
            get
            {
                return tree;
            }

            set
            {
                tree = value;
            }
        }
    }
}
