using System.Collections.Generic;

using System;

namespace AutoMainTreeMaker
{
    
    public class Tree
    {
        //ColumnSequence가 키.

        private Dictionary<int, TreeNode> nodeMap;
        private Dictionary<int, List<TreeNode>> tree;

        public Tree()
        {
            nodeMap = new Dictionary<int, TreeNode>();
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

        public void PutNodeToMap(int nodeSequence, TreeNode node)
        {
            nodeMap[nodeSequence] = node;
        }

        public TreeNode GetNode(int nodeSequece)
        {
            if (nodeMap.ContainsKey(nodeSequece))
                return nodeMap[nodeSequece];

            if (tree.ContainsKey(nodeSequece))
            {
                return tree[nodeSequece][0];
            }

            Dictionary<int, List<TreeNode>>.KeyCollection keys = tree.Keys;
            foreach (int key in keys)
            {
                List<TreeNode> list = tree[key];
                foreach(TreeNode node in list)
                {
                    if (node.NodeSequence == nodeSequece)
                    {
                        PutNodeToMap(nodeSequece, node);
                        return node;
                    }
                }
            }

            return null;
        }

        public bool containsNode(int nodeSeq)
        {
            return tree.ContainsKey(nodeSeq);
                
        }

    }
}
